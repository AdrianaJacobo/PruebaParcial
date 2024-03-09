using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaParcial.Models;

namespace PruebaParcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly EquiposContext _EquiposContexto;

        public equiposController(EquiposContext equiposContexto)
        {
            _EquiposContexto = equiposContexto;
        }

        /*[HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Equipo> listadoEquipo = (from e in _EquiposContexto.Equipos
                                          join t in _EquiposContexto.TipoEquipos
                                                on e.TipoEquipoId equals t.IdTipoEquipo
                                          join m in _EquiposContexto.Marcas
                                                on e.MarcaId equals m.IdMarcas
                                          join es in _EquiposContexto.EstadosEquipos
                                                on e.EstadoEquipoId equals es.IdEstadosEquipo
                                          select e).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoEquipo);
        }*/


        /*[HttpGet]
        [Route("GetAll")]

        public IActionResult Get() {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                        join t in _EquiposContexto.TipoEquipos
                                                on e.TipoEquipoId equals t.IdTipoEquipo
                                        join m in _EquiposContexto.Marcas
                                                on e.MarcaId equals m.IdMarcas
                                        join es in _EquiposContexto.EstadosEquipos
                                                on e.EstadoEquipoId equals es.IdEstadosEquipo
                                        select new
                                        {
                                            e.IdEquipos,
                                            e.Nombre,
                                            e.Descripcion,
                                            e.TipoEquipoId,
                                            TipoEquipo = t.Descripcion,
                                            e.MarcaId,
                                            marca = m.NombreMarca,
                                            e.EstadoEquipoId,
                                            EstadosEquipo = es.Descripcion,
                                            e.Estado
                                        }).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
                                        
        }*/

        /*[HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                        join t in _EquiposContexto.TipoEquipos
                                                on e.TipoEquipoId equals t.IdTipoEquipo
                                        join m in _EquiposContexto.Marcas
                                                on e.MarcaId equals m.IdMarcas
                                        join es in _EquiposContexto.EstadosEquipos
                                                on e.EstadoEquipoId equals es.IdEstadosEquipo
                                        select new
                                        {
                                            e.IdEquipos,
                                            e.Nombre,
                                            e.Descripcion,
                                            e.TipoEquipoId,
                                            TipoEquipo = t.Descripcion,
                                            e.MarcaId,
                                            marca = m.NombreMarca,
                                            e.EstadoEquipoId,
                                            EstadosEquipo = es.Descripcion,
                                            detalle = $"Tipo: {t.Descripcion}, Marca: {m.NombreMarca}, Estado Equipo: {es.Descripcion}",
                                            e.Estado
                                        }).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
        }*/

        /*[HttpGet]
        [Route("GetAll")]

        
        public IActionResult Get()
        {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                        join t in _EquiposContexto.TipoEquipos
                                                on e.TipoEquipoId equals t.IdTipoEquipo
                                        join m in _EquiposContexto.Marcas
                                                on e.MarcaId equals m.IdMarcas
                                        join es in _EquiposContexto.EstadosEquipos
                                                on e.EstadoEquipoId equals es.IdEstadosEquipo
                                 select new
                                 {
                                     e.IdEquipos,
                                     e.Nombre,
                                     e.Descripcion,
                                     e.TipoEquipoId,
                                     TipoEquipo = t.Descripcion,
                                     e.MarcaId,
                                     Marca = m.NombreMarca,
                                     e.EstadoEquipoId,
                                     EstadosEquipo = es.Descripcion,
                                     detalle = $"Tipo: {t.Descripcion}, Marca: {m.NombreMarca}, Estado Equipo: {es.Descripcion}",
                                     e.Estado
                                 }).Take(1).ToList();
        
        if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
        }*/

        /*[HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                 join t in _EquiposContexto.TipoEquipos
                                         on e.TipoEquipoId equals t.IdTipoEquipo
                                 join m in _EquiposContexto.Marcas
                                         on e.MarcaId equals m.IdMarcas
                                 join es in _EquiposContexto.EstadosEquipos
                                         on e.EstadoEquipoId equals es.IdEstadosEquipo
                                 select new
                                 {
                                     e.IdEquipos,
                                     e.Nombre,
                                     e.Descripcion,
                                     e.TipoEquipoId,
                                     TipoEquipo = t.Descripcion,
                                     e.MarcaId,
                                     Marca = m.NombreMarca,
                                     e.EstadoEquipoId,
                                     EstadosEquipo = es.Descripcion,
                                     detalle = $"Tipo: {t.Descripcion}, Marca: {m.NombreMarca}",
                                     e.Estado
                                 }).Skip(10).Take(10).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                 join t in _EquiposContexto.TipoEquipos
                                         on e.TipoEquipoId equals t.IdTipoEquipo
                                 join m in _EquiposContexto.Marcas
                                         on e.MarcaId equals m.IdMarcas
                                 join es in _EquiposContexto.EstadosEquipos
                                         on e.EstadoEquipoId equals es.IdEstadosEquipo
                                 select new
                                 {
                                     e.IdEquipos,
                                     e.Nombre,
                                     e.Descripcion,
                                     e.TipoEquipoId,
                                     TipoEquipo = t.Descripcion,
                                     e.MarcaId,
                                     Marca = m.NombreMarca,
                                     e.EstadoEquipoId,
                                     EstadosEquipo = es.Descripcion,
                                     detalle = $"Tipo: {t.Descripcion}, Marca: {m.NombreMarca}",
                                     e.Estado
                                 }).OrderBy(resultado => resultado.EstadoEquipoId).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                 join t in _EquiposContexto.TipoEquipos
                                         on e.TipoEquipoId equals t.IdTipoEquipo
                                 join m in _EquiposContexto.Marcas
                                         on e.MarcaId equals m.IdMarcas
                                 join es in _EquiposContexto.EstadosEquipos
                                         on e.EstadoEquipoId equals es.IdEstadosEquipo
                                 select new
                                 {
                                     e.IdEquipos,
                                     e.Nombre,
                                     e.Descripcion,
                                     e.TipoEquipoId,
                                     TipoEquipo = t.Descripcion,
                                     e.MarcaId,
                                     Marca = m.NombreMarca,
                                     e.EstadoEquipoId,
                                     EstadosEquipo = es.Descripcion,
                                     detalle = $"Tipo: {t.Descripcion}, Marca: {m.NombreMarca}, Estado Equipo: {es.Descripcion}",
                                     e.Estado
                                 }).OrderBy(resultado => resultado.EstadoEquipoId)
                                    .ThenBy(resultado => resultado.MarcaId)
                                    .ThenByDescending(resultado => resultado.TipoEquipoId).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
        }*/

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var listadoEquipo = (from e in _EquiposContexto.Equipos
                                 join t in _EquiposContexto.TipoEquipos
                                        on e.TipoEquipoId equals t.IdTipoEquipo
                                 join m in _EquiposContexto.Marcas
                                        on e.MarcaId equals m.IdMarcas
                                 join es in _EquiposContexto.EstadosEquipos
                                        on e.EstadoEquipoId equals es.IdEstadosEquipo
                                 select new
                                 {
                                     e.IdEquipos,
                                     e.Nombre,
                                     e.Descripcion,
                                     e.TipoEquipoId,
                                     TipoEquipo = t.Descripcion,
                                     e.MarcaId,
                                     marca = m.NombreMarca,
                                     e.EstadoEquipoId,
                                     EstadosEquipo = es.Descripcion,
                                     e.Estado
                                 }).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoEquipo);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult GuardarEquipo([FromBody] Equipo equipo)
        {
            try
            {
                _EquiposContexto.Equipos.Add(equipo);
                _EquiposContexto.SaveChanges();

                var equipos = new
                {
                    idEquipos = equipo.IdEquipos,
                    nombre = equipo.Nombre,
                    descripcion = equipo.Descripcion,
                    tipo_equipo_id = equipo.TipoEquipoId,
                    marca_id = equipo.MarcaId,
                    modelo = equipo.Modelo,
                    anio_compra = equipo.AnioCompra,
                    costo = equipo.Costo,
                    vida_util = equipo.VidaUtil,
                    estado_equipo_id = equipo.EstadoEquipoId,
                    estado = equipo.Estado
                };
                return Ok(equipos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("actualizar/{id}")]
        public IActionResult ActualizarEquipo(int id, [FromBody] Equipo equipoModificar)
        {
            //obtencion de registro original
            Equipo? equipoActual = (from e in _EquiposContexto.Equipos
                                    where e.IdEquipos == id
                                    select e).FirstOrDefault();

            //verificacion de existencia del registro segun ID
            if (equipoActual == null)
            {
                return NotFound();
            }
            //Alteración de los campos
            equipoActual.Nombre = equipoModificar.Nombre;
            equipoActual.Descripcion = equipoModificar.Descripcion;
            equipoActual.Modelo = equipoModificar.Modelo;
            equipoActual.AnioCompra = equipoModificar.AnioCompra;
            equipoActual.Costo = equipoModificar.Costo;
            equipoActual.VidaUtil = equipoModificar.VidaUtil;
            equipoActual.Estado = equipoModificar.Estado;
            //registro marcado como modificado en el contexto y se envia a la modificacion a la bd
            _EquiposContexto.Entry(equipoActual).State = EntityState.Modified;
            _EquiposContexto.SaveChanges();

            return Ok(equipoModificar);
        }
        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult EliminarEquipo(int id)
        {
            //Obtención de registro
            Equipo? equipo = (from e in _EquiposContexto.Equipos
                              where e.IdEquipos == id
                              select e).FirstOrDefault();
            //verificacion de la existencia del registro
            if (equipo == null)
            {
                return NotFound();
            }
            //Eliminación del registro
            _EquiposContexto.Equipos.Attach(equipo);
            _EquiposContexto.Equipos.Remove(equipo);
            _EquiposContexto.SaveChanges();

            return Ok(equipo);
        }

    }
}
