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
        body: JSON.stringify({"Email": username, "Contraseña":password})
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
   
    return fetch(`${config().apiUser}/login`, requestOptions)
        .then(handleResponse)
        .then(user => {
            localStorage.setItem('user', JSON.stringify(user)); 
            return user;
        });
}
function register(userobj){
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json'},
        body: JSON.stringify({
            "Email": userobj.Email,
            "Contraseña": userobj.Contraseña,
            "Nombres": userobj.Nombres,
            "Apellidos": userobj.Apellidos,
            "FechaRegistro": userobj.FechaRegistro
        })
    };

    return fetch(`${config().apiUser}/signup`, requestOptions)
        .then(handleResponse)
        .then(user => {
            console.log(user)

            return user;
        });
}
function logout() {
    localStorage.removeItem('user');
}

function handleResponse(response) {
    return response.text().then(text => {
        const data = text && JSON.parse(text);
        if (!response.ok) {
            if (response.status === 401) {
                console.log("401")
            }

            const error = (data && data.message) || response.statusText;
            return Promise.reject(error);
        }

        return data;
    });
}