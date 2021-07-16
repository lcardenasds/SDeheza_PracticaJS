using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult GetAll()
        {
            return View();
        }
        public JsonResult GetAllJson()
        {
            
            Models.Result result = new Models.Result();
            result.Objects = new List<object>();

            using (EntityFramework.EmpleadosEntities1 context = new EntityFramework.EmpleadosEntities1())
            {
                var query = context.EmpleadoGetAll().ToList();
                
                foreach (var empleadoItem in query)
                {
                    Models.EmpleadoModel empleado = new Models.EmpleadoModel();
                    empleado.IdEmpleado = empleadoItem.IdEmpleado;
                    empleado.Nombre = empleadoItem.Nombre;
                    empleado.ApellidoPaterno = empleadoItem.ApellidoPaterno;
                    empleado.ApellidoMaterno = empleadoItem.ApellidoMaterno;
                    empleado.Estado = new Models.Estado();
                    empleado.Estado.IdEstado = empleadoItem.IdEstado.Value;
                    empleado.Telefono = empleadoItem.Telefono;
                    empleado.Rol = new Models.Rol();
                    empleado.Rol.IdRol = empleadoItem.IdRol.Value;

                    result.Objects.Add(empleado);

                    result.Correct = true;
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult GetById(int IdEmpleado)
        {
            
            Models.Result result = new Models.Result();

            using (EntityFramework.EmpleadosEntities1 context = new EntityFramework.EmpleadosEntities1())
            {
                var query = context.EmpleadoGetById(IdEmpleado).FirstOrDefault();

                if(query !=null)
                {
                    Models.EmpleadoModel empleado = new Models.EmpleadoModel();
                
                    empleado.IdEmpleado = query.IdEmpleado;
                    empleado.Nombre = query.Nombre;
                    empleado.ApellidoPaterno = query.ApellidoPaterno;
                    empleado.ApellidoMaterno = query.ApellidoMaterno;
                    empleado.Estado = new Models.Estado();
                    empleado.Estado.IdEstado = query.IdEstado.Value;
                    empleado.Telefono = query.Telefono;
                    empleado.Rol = new Models.Rol();
                    empleado.Rol.IdRol = query.IdRol.Value;

                    result.Object = empleado;

                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }        


        public JsonResult Add(Models.EmpleadoModel empleado)
        {
            Models.Result result = new Models.Result();

                using (EntityFramework.EmpleadosEntities1 context = new EntityFramework.EmpleadosEntities1())
                {          
                                var query = context.EmpleadoAdd(empleado.Nombre, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.Estado.IdEstado, empleado.Telefono, empleado.Rol.IdRol);

                                if(query != 0)
                                {
                                    result.Correct = true;
                                }
                                else
                                {
                                    result.Correct = false;
                                    ViewBag.Message = "No se pudo agregar el empleado nuevo";
                                }
                }     
            
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Models.EmpleadoModel empleado)
        {
            Models.Result result = new Models.Result();

            using (EntityFramework.EmpleadosEntities1 context = new EntityFramework.EmpleadosEntities1())
            {
                var query = context.EmpleadoUpdate(empleado.IdEmpleado,empleado.Nombre, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.Estado.IdEstado, empleado.Telefono, empleado.Rol.IdRol);

                if (query != 0)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                }
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public JsonResult EstadoGetAll()
        {
            
            Models.Result result = new Models.Result();
            result.Objects = new List<object>();

            using (EntityFramework.EmpleadosEntities1 context = new EntityFramework.EmpleadosEntities1())
            {
                var query = context.EstadoGetAll().ToList();

                foreach (var estadoItem in query)
                {
                    Models.Estado estado = new Models.Estado();

                    estado.IdEstado = estadoItem.IdEstado;
                    estado.Nombre = estadoItem.Nombre;

                    result.Objects.Add(estado);

                    result.Correct = true;
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult RolGetAll()
        {
            
            Models.Result result = new Models.Result();

            result.Objects = new List<object>();

            using(EntityFramework.EmpleadosEntities1 context = new EntityFramework.EmpleadosEntities1())
            {
                var query = context.RolGetAll().ToList();

                if(query != null)
                {
                    foreach(var rolItem in query)
                    {
                        Models.Rol rol = new Models.Rol();
                        rol.IdRol = rolItem.IdRol;
                        rol.Nombre = rolItem.Nombre;

                        result.Objects.Add(rol);

                        result.Correct = true;
                    }
                }
                else
                {
                    result.Correct = false;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}