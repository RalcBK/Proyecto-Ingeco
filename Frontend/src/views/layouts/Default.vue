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
        @click="toLogout"
        v-if="isLogin"
      >
        <span class="mr-2">Salir</span>
        <v-icon>mdi-account-plus</v-icon>
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
    toHome(){
      this.$router.push('/inicio')
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
