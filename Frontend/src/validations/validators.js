import { required, email, max, min,integer,length } from "vee-validate/dist/rules";
import { extend } from "vee-validate";

extend("required", {
  ...required,
  message: "Este campo es obligatorio"
});

extend("integer", {
    ...integer,
    message: "Solo están permitidos números"
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
