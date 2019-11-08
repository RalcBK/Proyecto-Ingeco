const app = {
    state: {
        userIsLogin: false,
        rol: 2,
    },
    mutations:{
        SET_USERISLOGIN:(state,flag) =>{
            state.userIsLogin = flag
        }
    },
    actions:{
        setUserIsLogin({commit},{flag}){
            commit('SET_USERISLOGIN',flag)
        }
    }
}

export default app