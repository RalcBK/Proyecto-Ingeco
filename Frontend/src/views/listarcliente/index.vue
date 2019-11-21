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

        data() {
            return {
                headers: [
                    {text: 'RUC'},
                    {text: 'Razón Social'},
                    {text: 'Nombre Comercial'},
                    {text: 'Dirección Fiscal'},
                ],
                clientes: [
                    {
                        ruc: '20123456789',
                        razon_social: 'UPC S.A.C.',
                        nombre_comercial: 'UPC S.A.C.',
                        direccion_fiscal: 'Av. Primavera 2390',
                    }
                ]
            }
        },

        data: () => ({
            headers: [
                {
                    text: 'ID',
                    align: 'left',
                    sortable: false,
                    value: 'id',
                },

                { text: 'RUC', value: 'ruc' },
                { text: 'Razón Social', value: 'razonsocial' },
                { text: 'Nombre Comercial', value: 'nombrecomercial' },
                { text: 'Direccion Fiscal', value: 'direccionfiscal' },
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