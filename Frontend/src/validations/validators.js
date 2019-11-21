import { required, email, max, min,integer,length,numeric } from "vee-validate/dist/rules";
import { extend } from "vee-validate";

extend("required", {
  ...required,
  message: "Este campo es obligatorio"
});

extend("integer", {
    ...integer,
    message: "Solo están permitidos números"
});

extend('dinero', {
    message: 'The value is not a valid name.',
    validate: value => {
        let patt = /^\d{1,6}(\.\d{1,2})?$/
        
        return patt.test(value)
    }
});

extend("length", {
    ...length,
    message: "Este campo debe tener {length} caracteres"
});

extend("max", {
  ...max,
  message: "Este campo debe tener {length} caracteres o menos"
});

extend("min", {
    ...min,
    message: "Este campo debe tener {length} caracteres o más"
});

extend("email", {
  ...email,
  message: "Este campo debe tener un email válido"
});

extend('string', {
  message: 'No puede contener números',
  validate: value => {
      let patt = /^\[a-zA-Z]+$/
      
      return patt.test(value)
  }
});