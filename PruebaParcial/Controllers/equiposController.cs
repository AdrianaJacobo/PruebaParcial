using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        }

    }
}
