<script setup>
import {  RouterView } from 'vue-router'
import Header from '@/components/Header.vue';
import SideBar from '@/components/SideBar.vue';
</script>

<template>
  <Header />
  <SideBar />
  <RouterView />

</template>


