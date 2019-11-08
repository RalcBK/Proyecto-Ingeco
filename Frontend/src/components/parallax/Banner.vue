<template>
    
        <v-layout
        column
        align-center
        justify-center
        class="clayout"
        >
        
        <h1 class="mb-2 display-1 text-center">IngEco</h1>
        <div class="subheading mb-4 text-center">Bienvenido a la plataforma IngEco</div>
        </v-layout>
     
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
    toProducts(){
      this.$router.push('/productos')
    }
  },
};
</script>

<style>
.clayout{
    color: #010101;
}
</style>