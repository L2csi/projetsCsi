<!--linda waza Florence L2csi-->
<template>
  <div class="q-pa-md">
<q-card class="hd">
  <q-card-section>
    <div>
      
      <h6 class="text-center text-primary"> <q-avatar>
            <img src="public/jli.png">
          </q-avatar>Nos programmes</h6>
    </div>
  </q-card-section>
  <q-table
      flat bordered
      :rows="rows"
      :columns="columns"
      row-key="name"
    />
</q-card>

    
  </div>
</template>

<script>
const columns = [
  {
    name: 'name',
    required: true,
    label: 'Compagnies',
    align: 'left',
    field: row => row.name,
    format: val => `${val}`,
    sortable: true
  },
  { name: 'calories', align: 'center', label: 'Vols', field: 'calories', sortable: true },
  { name: 'fat', label: 'Jour de Depart', field: 'fat', sortable: true },
  { name: 'carbs', label: 'Heure de depart', field: 'carbs' },
  { name: 'protein', label: 'Jour Arrivé', field: 'protein' },
  { name: 'sodium', label: 'Heure Arrivée', field: 'sodium' },
  { name: 'calcium', label: 'priorite', field: 'calcium', sortable: true, sort: (a, b) => parseInt(a, 10) - parseInt(b, 10) },
  { name: 'iron', label: 'Mod', field: 'iron', sortable: true, sort: (a, b) => parseInt(a, 10) - parseInt(b, 10) }
]

const rows = [
  {
    name: 'C A A',
    calories: 152,
    fat: 6.0,
    carbs: 8,
    protein: 6,
    sodium: 10.0,
    calcium: '85%',
    iron: '15%'
  },
  {
    name: 'Congo airways',
    calories: 237,
    fat: 7.0,
    carbs: 1,
    protein: 7.0,
    sodium: 12,
    calcium: '85%',
    iron: '15%'
  },
  {
    name: 'FlyCongo',
    calories: 262,
    fat: 2.0,
    carbs: 23,
    protein: 2.0,
    sodium: 3,
    calcium: '85%',
    iron: '15%'
  },
  {
    name: 'Ethiopan',
    calories: 305,
    fat: 3.0,
    carbs: 7,
    protein: 3.0,
    sodium: 12,
    calcium: '85%',
    iron: '15%'
  },
  {
    name: 'Wimbidira Airways',
    calories: 356,
    fat: 5.0,
    carbs: 9,
    protein: 5.0,
    sodium: 17,
    calcium: '85%',
    iron: '15%'
  },
  {
    name: 'Jelly bean',
    calories: 375,
    fat: 0.0,
    carbs: 94,
    protein: 0.0,
    sodium: 50,
    calcium: '0%',
    iron: '0%'
  },
  {
    name: 'Lollipop',
    calories: 392,
    fat: 0.2,
    carbs: 98,
    protein: 0,
    sodium: 38,
    calcium: '0%',
    iron: '2%'
  },
  {
    name: 'Honeycomb',
    calories: 408,
    fat: 3.2,
    carbs: 87,
    protein: 6.5,
    sodium: 562,
    calcium: '0%',
    iron: '45%'
  },
  {
    name: 'Donut',
    calories: 452,
    fat: 25.0,
    carbs: 51,
    protein: 4.9,
    sodium: 326,
    calcium: '2%',
    iron: '22%'
  },
  {
    name: 'KitKat',
    calories: 518,
    fat: 26.0,
    carbs: 65,
    protein: 7,
    sodium: 54,
    calcium: '12%',
    iron: '6%'
  }
]

export default {
  setup () {
    return {
      columns,
      rows
    }
  }
}
</script>

<style lang="scss">
// @import url('https://fonts.googleapis.com/css2?family=Lobster+Two&display=swap');
.hd{
  box-shadow: 5px 5px 10px rgba(37, 97, 227, 0.5);
}
 
</style>