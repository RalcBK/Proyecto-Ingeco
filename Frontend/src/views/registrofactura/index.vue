<template>
  <v-container fluid fill-height>
    <v-layout align-center justify-center>
      <v-flex xs12 sm4 md4>
        <ValidationObserver ref="obs" v-slot="{ invalid, validated, passes, validate }">
            <v-card class="elevation-12">
                <v-toolbar dark color="primary">
                <v-toolbar-title>Registro de Factura</v-toolbar-title>
                </v-toolbar>
                <v-card-text class="pb-0">
                <v-form>
                    <VBoxFieldWithValidation rules="required" v-model="serie" label="Serie" />
                    <VBoxFieldWithValidation rules="required|integer|length:10" v-model="ruc" :counter="10" label="Correlativo" />
                    <v-text-field label="Fecha de venta" v-model="fechaventa" type="date"></v-text-field>
                    <VBoxFieldWithValidation rules="required" v-model="descripcion" label="Monto" />
                    <v-text-field label="Fecha de vencimiento" v-model="fechavencimiento" type="date"></v-text-field>
                </v-form>
                </v-card-text>
                <v-card-actions>
                <v-container>
                    <v-row no-gutters>
                    <v-col class="text-center">
                        <v-btn color="primary" @click="" >Cancelar</v-btn>
                    </v-col>
                    <v-col class="text-center">
                        <v-btn color="primary" @click="" >Guardar</v-btn>
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
import VBoxFieldWithValidation from '@/components/inputs/VBoxFieldWithValidation';
import {ValidationObserver} from "vee-validate";
export default {
    name: 'App',
    components: {
        VBoxFieldWithValidation,
        ValidationObserver
    },
    data: () => ({

    }),
    methods: {
        
    }
}
</script>