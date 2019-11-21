<template>
  <v-app>
    <v-app-bar app>
      <v-toolbar-title class="headline">
        <span @click="toHome">ProFactoring</span>
      </v-toolbar-title>
      <v-spacer></v-spacer>

      <v-btn
        text
        @click="toLogin"
        v-if="!isLogin"
      >
        <span class="mr-2">Ingresar</span>
        <v-icon>mdi-login</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toRegister"
        v-if="!isLogin"
      >
        <span class="mr-2">Registrar</span>
        <v-icon>mdi-account-plus</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toListarCliente"
        v-if="isLogin"
      >
        <span class="mr-2">Listar Clientes</span>
        <v-icon>mdi-calendar-text-outline</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toRegistroCliente"
        v-if="isLogin"
      >
        <span class="mr-2">Registro Clientes</span>
        <v-icon>mdi-calendar-text-outline</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toListarFactura"
        v-if="isLogin"
      >
        <span class="mr-2">Listar Facturas</span>
        <v-icon>mdi-calendar-text-outline</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toRegistroFactura"
        v-if="isLogin"
      >
        <span class="mr-2">Registro Factura</span>
        <v-icon>mdi-calendar-text-outline</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toListarDescuento"
        v-if="isLogin"
      >
        <span class="mr-2">Listar Descuentos</span>
        <v-icon>mdi-calendar-text-outline</v-icon>
      </v-btn>
      <v-btn
        text
        @click="toLogout"
        v-if="isLogin"
      >
        <span class="mr-2">Salir</span>
        <v-icon>mdi-account-less</v-icon>
      </v-btn>
    </v-app-bar>
    
    <v-content>
      <slot/>
    </v-content>
    
  </v-app>
 
</template>

<script>
export default {
  name: 'App',
  components: {
  },
  data: () => ({
    //
  }),
  methods: {
    toLogin(){
      this.$router.push('/login')
    },
    toRegister(){
      this.$router.push('/registro')
    },
    toLogout(){
      this.$store.dispatch('logout')
      this.$router.push('/login')
    },
    toRegistroFactura(){
      this.$router.push('/registro-factura')
    },
    toHome(){
      this.$router.push('/inicio')
    },
    toListarFactura(){
      this.$router.push('/listar-factura')
    },
    toListarCliente(){
      this.$router.push('/listar-cliente')
    },
    toRegistroCliente(){
      this.$router.push('/registro-cliente')
    },
    toListarDescuento(){
      this.$router.push('/listar-descuento')
    },
  },
  computed:{
    isLogin(){
      return this.$store.state.user.status.loggedIn
    },
    checkRol(){
      return this.$store.state.user.rol
    }
  },
};
</script>
