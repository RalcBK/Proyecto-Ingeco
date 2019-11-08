import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Inicio',
    component: Home,
    meta: { layout: 'default' ,title:'Bienvenido'},
    component: () => import(/* webpackChunkName: "home" */'@/views/inicio'),
  },
  {
    path: '/inicio',
    name: 'Inicio',
    component: Home,
    meta: { layout: 'default' ,title:'Bienvenido'},
    component: () => import(/* webpackChunkName: "home" */'@/views/inicio'),
  },
  {
    path: '/registro',
    name: 'registro',
    meta: { layout: 'default' ,title:'Registro'},
    component: () => import(/* webpackChunkName: "about" */ '@/views/registrousuario')
  },
  {
    path: '/login',
    name: 'login',
    meta: { layout: 'default' ,title:'Login'},
    component: () => import(/* webpackChunkName: "about" */ '@/views/loginusuario')
  },
]

const router = new VueRouter({
  routes
})

export default router
