<template>
  <component :is="layout">
    <router-view/>
  </component>
</template>

<script>

export default {
  name: 'App',

  data() {
    return {
      default_layout: 'default',
    };
  },
  computed: {
    layout() {
      return `${this.$route.meta.layout || this.default_layout}-layout`;
    },
  },
};
</script>