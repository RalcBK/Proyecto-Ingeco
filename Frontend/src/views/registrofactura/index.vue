<template>
  <v-container fluid fill-height>
    <v-layout align-center justify-center>
      <v-flex xs12 sm8 md6>
        <ValidationObserver ref="obs" v-slot="{ invalid, validated, passes, validate }">
            <v-card class="elevation-12">
                <v-toolbar dark color="primary">
                <v-toolbar-title>Registro de Factura</v-toolbar-title>
                </v-toolbar>
                <v-card-text class="pb-0">
                <v-form>
                    <VBoxFieldWithValidation rules="required|integer" v-model="serie" label="Serie" />
                    <VBoxFieldWithValidation rules="required|integer" v-model="correlativo" :counter="10" label="Correlativo" />
                    <v-text-field label="Fecha de venta" v-model="fechaventa" type="date"></v-text-field>
                    <VBoxFieldWithValidation rules="required|dinero" v-model="monto" label="Monto" />
                    <v-text-field label="Fecha de vencimiento" v-model="fechavencimiento" type="date"></v-text-field>
                </v-form>
                </v-card-text>
                <v-card-actions>
                <v-container>
                <v-row no-gutters>
                  <v-col class="text-center">
                    <v-btn color="primary" block large @click="passes(submit)" :disabled="invalid || !validated">Agregar Factura</v-btn>
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
      serie: 0,
      correlativo: 0,
      fechaventa: null,
      monto: 0,
      fechavencimiento: null,
    }),
    methods: {
      submit(){
        let obj = {
                    Serie: this.serie.toString(),
                    Correlativo: this.correlativo.toString(),
                    FechaVenta: this.parseDate(this.fechaventa),
                    Monto: parseFloat(this.monto),
                    FechaVencimiento: this.parseDate(this.fechavencimiento),
                    ClienteId: 1
                  }
        console.log(obj)
        this.$store.dispatch('addFactura', { obj: obj })
          
      },
      parseDate: function(date){
        let datan = date.split("-")
        return datan[1] + "-" + datan[2] +"-" +datan[0]
      }
    },
    computed: {
      
  },
}
</script>