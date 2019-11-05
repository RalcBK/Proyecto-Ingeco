import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import './plugins/vuetify'
import "@/validations/validators"

import axios from 'axios'

import Principal from './views/layouts/default.vue'

Vue.component('default-layout', Principal)

Vue.config.productionTip = false

axios.defaults.baseURL='http://localhost:5000/'

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
