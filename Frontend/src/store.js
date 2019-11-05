import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    isLogged : false,
    token: ""
  },
  mutations: {
    SET_USERISLOGIN:(state,flag) =>{
      state.isLogged = flag
    },
    SET_TOKEN:(state,token) =>{
      state.token = token
    }
  },
  actions: {
    setUserIsLogin({commit},{flag}){
      commit('SET_USERISLOGIN',flag)
    },
    setToken({commit},{token}){
      commit('SET_TOKEN', token)
    }
  }
})
