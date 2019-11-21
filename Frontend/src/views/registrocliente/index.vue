<template>
    <v-container fluid fill-height>
        <v-layout align-center justify-center>
            <v-flex xs12 sm8 md6>
                <ValidationObserver ref="obs" v-slot="{ invalid, validated, passes, validate }">
                    <v-card class="elevation-12">
                        <v-toolbar dark color="primary">
                            <v-toolbar-title>Registro de Cliente</v-toolbar-title>
                        </v-toolbar>
                        <v-card-text class="pb-0">
                            <v-form>
                                <VBoxFieldWithValidation rules="required|ruc|integer" :counter="11" v-model="ruc" label="RUC" />
                                <VBoxFieldWithValidation rules="required" v-model="razonsocial" label="Razon Social" />
                                <VBoxFieldWithValidation rules="required" v-model="nombrecomercial" label="Nombre Comercial" />
                                <VBoxFieldWithValidation rules="required" v-model="direccionfiscal" label="Direccion Fiscal" />
                            </v-form>
                        </v-card-text>
                        <v-card-actions>
                            <v-container>
                                <v-row no-gutters>
                                    <v-col class="text-center">
                                        <v-btn color="primary" block large @click="passes(submit)" :disabled="invalid || !validated">Agregar Cliente</v-btn>
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
        name: "index",
        components: {
            VBoxFieldWithValidation,
            ValidationObserver
        },
        data: () => ({
            ruc: '',
            razonsocial: '',
            nombrecomercial: '',
            direccionfiscal: '',
        }),
        methods: {
            submit(){
                let obj = {
                    RUC: this.ruc.toString(),
                    RazonSocial: this.razonsocial,
                    NombreComercial: this.nombrecomercial,
                    DireccionFiscal:this.direccionfiscal,
                };
                console.log(obj)
                this.$store.dispatch('addCliente', { obj: obj })

            },
        },
    }
</script>

<style scoped>

</style>