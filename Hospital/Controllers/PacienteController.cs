using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PacienteBD.Modelo;

namespace Hospital.Controllers
{
    public class PacienteController : ApiController
    {
        hospitalEntities BD = new hospitalEntities();

        // GET api/Paciente
        public IEnumerable<paciente> Get()
        {
            return BD.paciente.ToList();
        }

        // GET api/Paciente/5
        public paciente Get(int id)
        {
            var a = BD.paciente.FirstOrDefault(x => x.Id == id);
            return a;
        }

        // POST api/Paciente
        public IHttpActionResult  Post(paciente persona)
        {
            using (var pac = new hospitalEntities())
            {
                pac.paciente.Add(new paciente()
                {
                    Nombre = persona.Nombre,
                    Apellido = persona.Apellido,
                    Documento = persona.Documento,
                    Direccion = persona.Direccion,
                    Telefono = persona.Telefono,
                    Correo = persona.Correo,
                    Edad = persona.Edad,
                    Peso = persona.Peso,
                    Fecha_Nacimiento = persona.Fecha_Nacimiento

                });

                pac.SaveChanges();
            }

            return Ok("Paciente creado correctamente");
        }

        // PUT api/Paciente/5
        public IHttpActionResult Put( paciente persona)
        {
           
            using (var pac = new hospitalEntities())
            {
                var pacienteUpdate = pac.paciente.Find(persona.Id);

                pacienteUpdate.Id = persona.Id;
                pacienteUpdate.Nombre = persona.Nombre;
                pacienteUpdate.Apellido = persona.Apellido;
                pacienteUpdate.Documento = persona.Documento;
                pacienteUpdate.Direccion = persona.Direccion;
                pacienteUpdate.Telefono = persona.Telefono;
                pacienteUpdate.Correo = persona.Correo;
                pacienteUpdate.Edad = persona.Edad;
                pacienteUpdate.Peso = persona.Peso;
                pacienteUpdate.Fecha_Nacimiento = persona.Fecha_Nacimiento;

                pac.SaveChanges();
            }
            return Ok("Paciente Actualizado correctamente");
        }
        // DELETE api/Paciente/5
        public IHttpActionResult Delete(int id)
        {
            paciente persona = null;

            using (var pac = new hospitalEntities())
            {
                persona = pac.paciente.Find(id);

                pac.Entry(persona).State = System.Data.Entity.EntityState.Deleted;
                pac.SaveChanges();
            }

            return Ok("Paciente Eliminado correctamente");
        }
    }
}
