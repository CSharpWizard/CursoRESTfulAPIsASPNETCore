using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAPIAutores.Controllers.V1;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.Tests.PruebasUnitarias
{
    [TestClass]
    public class PrimeraLetraMayusculaAttributeTests
    {
        [TestMethod]
        public void PrimeraLetraMinuscula_DevuelveError()
        {
            // Preparaci�n
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n
            Assert.AreEqual("La primera letra debe ser may�scula", resultado.ErrorMessage);
        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            // Preparaci�n
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = null;
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n
            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void ValorConPrimeraLetraMayuscula_NoDevuelveError()
        {
            // Preparaci�n
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = "Felipe";
            var valContext = new ValidationContext(new { Nombre = valor });

            // Ejecuci�n
            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            // Verificaci�n
            Assert.IsNull(resultado);
        }
    }
}
