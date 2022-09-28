import  {environment} from '../../environments/environment'


export let BASEURL = environment.Api;



export let APIURL = {

Visitante: {
  lista: BASEURL + 'Visitante/Lista',
  Agregar: BASEURL + 'Visitante/Agregar',
  editar: BASEURL + '/Visitante/Edita',
  inactivar: BASEURL + '/Visitante/Inactiva'
},
Eventos: {
  lista: BASEURL + 'Eventos/Lista',
  agregar: BASEURL + 'Eventos/Inserta',
  editar: BASEURL + 'Eventos/edita',
  inactiva: BASEURL + 'Eventos/Inactiva'
}




}
