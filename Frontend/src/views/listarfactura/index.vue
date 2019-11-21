<template>
  <v-container fluid fill-height>
    <v-layout align-center justify-center>
      <v-flex xs12 sm12 md12>
        <v-card class="elevation-12">
          <v-toolbar dark color="primary">
            <v-toolbar-title>Lista de Facturas</v-toolbar-title>
          </v-toolbar>
          <v-card-text class="pb-0">            
            <v-data-table
              :headers="headers"
              :items="facturasItems"
              :items-per-page="10"
              class="elevation-1"
            ></v-data-table>
          </v-card-text>
          <v-card-actions>
            <v-container>
              <v-row no-gutters>
                <v-col class="text-center">
                  <v-btn color="primary" block large @click="toRegistroFactura">Agregar Factura</v-btn>
                </v-col>
              </v-row>
            </v-container>
          </v-card-actions>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  name: "App",
  components: {},
  data: () => ({
    headers: [
      {
        text: "ID",
        align: "left",
        sortable: false,
        value: "id"
      },
      { text: "Serie", value: "serie" },
      { text: "Correlativo", value: "correlativo" },
      { text: "Fecha de venta", value: "fechaVenta" },
      { text: "Monto", value: "monto" },
      { text: "Fecha de Vencimiento", value: "fechaVencimiento" },
      { text: "Cliente", value: "nombreCliente" }
    ],
    items: []
  }),
  async created() {
    var that = this;

    await this.$store.dispatch("updateFacturas");
  },
  methods: {
    toRegistroFactura() {
      this.$router.push("/registro-factura");
    },
    descontar() {
      let obj = {
        RUC: this.ruc.toString(),
        RazonSocial: this.razonsocial,
        NombreComercial: this.nombrecomercial,
        DireccionFiscal: this.direccionfiscal
      };
      console.log(obj);
      this.$store.dispatch("addCliente", { obj: obj });
    }
  },
  computed: {
    facturasItems: function() {
      return this.$store.state.user.facturas;
    }
  }
};
</script>