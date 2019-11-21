import { userService } from '@/services';
import  router  from '@/router/index.js'

const user = JSON.parse(localStorage.getItem('user'));
const initialState = user
    ? { status: { loggedIn: true }, user }
    : { status: { loggedIn: false }, user: null };

const app = {
    state: initialState,
    mutations:{
        loginRequest(state, user) {
            state.status = { loggingIn: true };
            state.user = user;
        },
        loginSuccess(state, user) {
            state.status = { loggedIn: true };
            state.user = user;
        },
        loginFailure(state) {
            state.status = {};
            state.user = null;
        },
        registerRequest(state, user) {
            state.status = { loggingIn: true };
            state.user = user;
        },
        registerSuccess(state, user) {
            state.status = { loggedIn: true };
            state.user = user;
        },
        registerFailure(state) {
            state.status = {};
            state.user = null;
        },
        logout(state) {
            state.status = {}; 
            state.user = null;
        },

    },
    actions:{
        login({ dispatch, commit }, { username, password }) {
            commit('loginRequest', { username });

            userService.login(username, password)
                .then(
                    user => {
                        commit('loginSuccess', user);
                        router.push('/inicio')
                    },
                    error => {
                        commit('loginFailure', error);
                        alert("Error en el logeo")
                    }
                );
        },
        register({ dispatch, commit }, { obj }) {
            commit('registerRequest', { obj });

            userService.register(obj)
                .then(
                    user => {
                        commit('registerSuccess', user);
                        router.push('/inicio')
                    },
                    error => {
                        commit('registerFailure', error);
                        alert("Registro incorrecto")
                        
                    }
                );
        },
        logout({ commit }) {
            userService.logout();
            commit('logout');
        } 
    }
}

export default app