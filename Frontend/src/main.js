import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify';
import { configure } from 'vee-validate';
import { ValidationProvider, extend } from 'vee-validate';

import "@/validations/validators"


//Layouts
import Default from './views/layouts/Default.vue';

configure({
  useConstraintAttrs: true
});
Vue.component('default-layout', Default);
Vue.component('ValidationProvider', ValidationProvider);

Vue.config.productionTip = false

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')
