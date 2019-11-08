<template>
  <v-container fluid fill-height>
    <v-layout align-center justify-center>
      <v-flex xs12 sm8 md4>
        <ValidationObserver ref="obs" v-slot="{ invalid, validated, passes, validate }">
          <v-card class="elevation-12" :loading="loading">
            <v-toolbar dark color="primary">
              <v-toolbar-title>Registro de Usuario</v-toolbar-title>
            </v-toolbar>
            <v-card-text class="pb-0">
              <v-form>
                <VTextFieldWithValidation rules="required|min:3" v-model="name" :counter="10" label="Nombre del responsable" />
                <VTextFieldWithValidation rules="required|integer|length:10" v-model="ruc" :counter="10" label="R.U.C" />
                <VTextFieldWithValidation rules="required|email" v-model="email" :counter="10" label="E-Mail" />
                <VTextFieldWithValidation rules="required|min:6" v-model="password" :counter="10" label="Contraseña" />
              </v-form>
            </v-card-text> 
            <v-card-actions>
              <v-container>
                <v-row no-gutters>
                  <v-col class="text-center">
                    <v-btn color="primary" block large @click="passes(submit)" :disabled="invalid || !validated"
                      >Sign Up</v-btn>
                  </v-col>
                </v-row>
              </v-container>
            </v-card-actions>
          </v-card>
        </ValidationObserver>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
import Vue from 'vue'
import VTextFieldWithValidation from '@/components/inputs/VTextFieldWithValidation';
import {ValidationObserver} from "vee-validate";
export default {
  name: 'App',
  components: {
    VTextFieldWithValidation,
    ValidationObserver
  },
  data: () => ({
    loading:false,
    name : "",
    email: "",
    password:"",
    ruc:"",

  }),
  methods: {
    async submit() {
      this.loading = true
      await this.$store.dispatch('setUserIsLogin', { flag: true })
      this.loading = false
      this.$router.push('/inicio')
    }
  }
};
</script>
