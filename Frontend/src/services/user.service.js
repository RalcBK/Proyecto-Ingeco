import config from '@/helpers/config.api';
import { authHeader } from '@/helpers';

export const userService = {
    login,
    register,
    logout
};

function login(username, password) {
    const credenciales = btoa('frontendapp' + ':' + '12345');
    /*const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/x-www-form-urlencoded',
                    'Authorization': 'Basic ' + credenciales },

        
        body: JSON.stringify({ username, password })
    };*/
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json'},
        body: JSON.stringify({"username": username, "password":password})
    };

    /*var usertemp = {email: "asdfg@asdf.com",
                enabled: true,
                idUser: 7,
                password: "ASDFGHJ",
                rol: 2,
                username: "sdfgh",
                token: credenciales,
                }
    localStorage.setItem('user', JSON.stringify(usertemp)); 
    
    return new Promise((resolve, reject)=>{
        resolve(usertemp);
    })*/
   
    return fetch(`${config().apiUrlUser}/user/login`, requestOptions)
        .then(handleResponse)
        .then(user => {
            // login successful if there's a jwt token in the response
            if (user.enabled) {
                // store user details and jwt token in local storage to keep user logged in between page refreshes
                user.rol = 2;
                localStorage.setItem('user', JSON.stringify(user)); 
            }

            return user;
        });
}
function register(username,password,email){
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json'},
        body: JSON.stringify({ "email": email, "username": username, "password":password, "enabled": true })
    };

    return fetch(`${config().apiUrlUser}/user`, requestOptions)
        .then(handleResponse)
        .then(user => {
            // login successful if there's a jwt token in the response
            console.log(user)

            return user;
        });
}
function logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('user');
}

function handleResponse(response) {
    return response.text().then(text => {
        const data = text && JSON.parse(text);
        if (!response.ok) {
            if (response.status === 401) {
                // auto logout if 401 response returned from api
                //logout();
                //location.reload(true);
                console.log("401")
            }

            const error = (data && data.message) || response.statusText;
            return Promise.reject(error);
        }

        return data;
    });
}