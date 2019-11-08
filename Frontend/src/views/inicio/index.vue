<template>
  <div class="home">
    <Banner></Banner>
  </div>
</template>

<script>
// @ is an alias to /src
import Banner from '@/components/parallax/Banner.vue'

export default {
  name: 'home',
  components: {
    Banner
  }
}
</script>
