<template>
  <v-container>
    <v-layout
      text-xs-center
      wrap
    >
      <v-flex xs12>
        <v-img
          :src="require('../assets/logo.svg')"
          class="my-3"
          contain
          height="200"
        ></v-img>
      </v-flex>

      <v-flex mb-4>
        <h1 class="display-2 font-weight-bold mb-3">
          Bienvenido a la calculadora de cartera de facturas
        </h1>
        <p class="subheading font-weight-regular">
          Para hacer uso de las funcionalidades, es necesario registrarse
        </p>
      </v-flex>

      <v-flex
        mb-5
        xs12
      >
        <v-icon color="#E53935" size="70">note_add</v-icon>
        <h2 class="headline font-weight-bold mb-3">Agrega o elimina facturas</h2>
      </v-flex>

      <v-flex
        xs12
        mb-5
      >
        <v-icon color="#E53935" size="70">compare_arrows</v-icon>
        <h2 class="headline font-weight-bold mb-3">Compara entre diversas opciones</h2>
      </v-flex>

      <v-flex
        xs12
        mb-5
      >
        <v-icon color="#E53935" size="70">verified_user</v-icon>
        <h2 class="headline font-weight-bold mb-3">Verifica tu cartera de facturas</h2>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
  export default {
    data: () => ({
      
    })
  }
</script>

<style>

</style>
