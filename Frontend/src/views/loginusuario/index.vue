<template>
  <v-container fluid fill-height>
    <v-layout align-center justify-center>
      <v-flex xs12 sm8 md4>
        <ValidationObserver ref="obs" v-slot="{ invalid, validated, passes, validate }">
          <v-card class="elevation-12" :loading="loading">
            <v-toolbar dark color="primary">
              <v-toolbar-title>Iniciar Sesión</v-toolbar-title>
            </v-toolbar>
            <v-card-text class="pb-0">
              <v-form>
                <VTextFieldWithValidation rules="required|email" v-model="email" :counter="10" label="E-Mail" />
                <VTextFieldWithValidation type="password" rules="required|min:6" v-model="password" :counter="10" label="Contraseña" />
              </v-form>
            </v-card-text>
            <v-card-actions>
              <v-container>
                <v-row no-gutters>
                  <v-col class="text-center">
                    <v-btn color="primary" block large @click="passes(submit)" :disabled="invalid || !validated">Login</v-btn>
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
import VTextFieldWithValidation from '@/components/inputs/VTextFieldWithValidation';
import {ValidationObserver} from "vee-validate";
export default {
  name: 'App',
  components: {
    VTextFieldWithValidation,
    ValidationObserver
  },
  data: () => ({
    loading: false,
    email: "",
    password: "",
  }),
  methods: {
    async submit() {
      this.loading = true
      await this.$store.dispatch('login', { username: this.email, password: this.password })
      this.loading = false
    }
  }
};
</script>
