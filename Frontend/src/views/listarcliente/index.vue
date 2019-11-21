<template>
    <v-container fluid fill-height>
        <v-layout align-center justify-center>
            <v-flex xs12 sm12 md12>
                <v-card class="elevation-12">
                    <v-toolbar dark color="primary">
                        <v-toolbar-title>Lista de Clientes</v-toolbar-title>
                    </v-toolbar>
                    <v-card-text class="pb-0">
                        <v-data-table
                                :headers="headers"
                                :items="clientesItems"
                                :items-per-page="10"
                                class="elevation-1"
                        ></v-data-table>
                    </v-card-text>
                    <v-card-actions>
                        <v-container>
                            <v-row no-gutters>
                                <v-col class="text-center">
                                    <v-btn color="primary" block large @click="toRegistroCliente">Agregar Cliente
                                    </v-btn>
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
        name: "index",

       

        data: () => ({
            headers: [
                {
                    text: 'ID',
                    align: 'left',
                    sortable: false,
                    value: 'id',
                },

                { text: 'RUC', value: 'ruc' },
                { text: 'Razón Social', value: 'razonSocial' },
                { text: 'Nombre Comercial', value: 'nombreComercial' },
                { text: 'Direccion Fiscal', value: 'domicilioFiscal' },
            ],
            items: [],
        }),

        async created() {
            var that = this;

            await this.$store.dispatch('updateClientes')

        },

        methods: {
            toRegistroCliente() {
                this.$router.push('/registro-cliente')
            },
        },

        computed: {
            clientesItems: function () {
                return this.$store.state.user.clientes;
            }
        }
    }
</script>

<style scoped>

</style>