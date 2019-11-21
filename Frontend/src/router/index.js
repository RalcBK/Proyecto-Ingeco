import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Inicio',
    meta: { layout: 'default' ,title:'Bienvenido'},
    component: () => import(/* webpackChunkName: "home" */'@/views/inicio'),
  },
  {
    path: '/inicio',
    name: 'Inicio',
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
  {
    path: '/registro_factura',
    name: 'registro_factura',
    meta: { layout: 'default' ,title:'Registro de Factura'},
    component: () => import(/* webpackChunkName: "about" */ '@/views/registrofactura')
  },
]

const router = new VueRouter({
  routes
})

export default router
