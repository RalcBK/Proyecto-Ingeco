<template>
    <v-container fluid fill-height>
        <v-layout align-center justify-center>
            <v-flex xs12 sm8 md6>
                <ValidationObserver ref="obs" v-slot="{ invalid, validated, passes, validate }">
                    <v-card class="elevation-12">
                        <v-toolbar dark color="primary">
                            <v-toolbar-title>Descuento de factura</v-toolbar-title>
                        </v-toolbar>
                        <v-card-text class="pb-0">
                            <v-form>
                                <v-text-field label="Fecha" v-model="fecha" type="date"></v-text-field>
                                <VBoxFieldWithValidation rules="required" v-model="tasa" label="Tasa" />
                                <VBoxFieldWithValidation rules="required" v-model="montoDescontado" label="MontoDescontado" />
                                <VBoxFieldWithValidation rules="required" v-model="tea" label="TEA" />
                                <VBoxFieldWithValidation rules="required" v-model="tcea" label="TCEA" />
                                <VBoxFieldWithValidation rules="required" v-model="facturaId" label="Factura" />
                                <VBoxFieldWithValidation rules="required" v-model="bancoId" label="Banco" />
                            </v-form>
                        </v-card-text>
                        <v-card-actions>
                            <v-container>
                                <v-row no-gutters>
                                    <v-col class="text-center">
                                        <v-btn color="primary" block large @click="passes(submit)" :disabled="invalid || !validated">Descontar</v-btn>
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
            fecha: '',
            tasa: '',
            montoDescontado: '',
            tea: '',
            tcea: '',
            facturaId: '',
            bancoId: '',
        }),
        methods: {
            submit(){
                let obj = {
                    FechaVenta: this.parseDate(this.fecha),
                    Tasa: parseFloat(this.monto),
                    MontoDescontado: parseFloat(this.montoDescontado),
                    TEA: parseFloat(this.tea),
                    TCEA: parseFloat(this.tcea),
                    FacturaId: this.facturaId,
                    BancoId: this.bancoId,
                };
                console.log(obj)
                this.$store.dispatch('addDescuento', { obj: obj })

            },
        },
    }
</script>

<style scoped>

</style>