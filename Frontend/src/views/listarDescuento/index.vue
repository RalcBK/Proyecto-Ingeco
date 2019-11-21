<template>
  <v-container fluid fill-height>
    <v-layout align-center justify-center>
      <v-flex xs12 sm12 md12>
            <v-card class="elevation-12">
                <v-toolbar dark color="primary">
                <v-toolbar-title>Lista de Descuentos</v-toolbar-title>
                </v-toolbar>
                <v-card-text class="pb-0">
                <v-data-table
                    :headers="headers"
                    :items="descuentosItems"
                    :items-per-page="10"
                    class="elevation-1"
                ></v-data-table>
                </v-card-text>
                <v-card-actions>
                    <v-container>
                        <v-row no-gutters>
                        <v-col class="text-center">
                            <v-text-field label="TCEA de la cartera" v-model="TCEACartera" type="text" disabled filled></v-text-field>
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
    name: 'App',
    components: {
    },
    data: () => ({
      headers: [
          {
            text: 'ID',
            align: 'left',
            sortable: false,
            value: 'id',
          },
          { text: 'Fecha', value: 'fecha' },
          { text: 'Tasa', value: 'tasa' },
          { text: 'Monto', value: 'monto' },
          { text: 'TEA', value: 'tea' },
          { text: 'TCEA', value: 'tcea' },
          { text: 'Factura', value: 'serie' },
          { text: 'Banco', value: 'nombreBanco' }
        ],
        items: [],
    }),
    async created() {
        await this.$store.dispatch('updateDescuentos')

    },
    computed: {
      descuentosItems: function(){
          return this.$store.state.user.descuentos;
      },

        TCEACartera() {
          let total_tcea = 0;
          let cantidad = this.items.length;

          if (cantidad === 0) {
              return 0 + '%';
          }

          this.items.forEach(descuento => {
              total_tcea += descuento.tcea;
          });

          return (total_tcea / cantidad).toFixed(7) + '%';
        },
  },
}
</script>