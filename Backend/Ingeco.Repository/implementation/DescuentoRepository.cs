using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;
using Ingeco.Repository.dto;
using Microsoft.EntityFrameworkCore;

namespace Ingeco.Repository.implementation
{
    public class DescuentoRepository : IDescuentoRepository
    {
        private ApplicationDbContext context;

        public DescuentoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public bool Delete(int id)
        {
            try
            {
                var obj = context.Descuentos.Single(
                    x => x.Id == id
                );
                context.Descuentos.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public Descuento Get(int id)
        {
            var result = new Descuento();
            try
            {
                result = context.Descuentos.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Descuento> GetAll()
        {
            var result = new List<Descuento>();
            try
            {
                result = context.Descuentos.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<DescuentoDto> getDescuentosFromFactura(int usuarioId)
        {
            try
            {
                var result = context.Descuentos
                .Include(t => t.Factura)
                .Include(t => t.Banco)
                .Where(x => x.Factura.UsuarioId == usuarioId)
                .ToList();

                return result.Select(o => new DescuentoDto
                {
                    Id = o.Id,
                    Fecha = o.Fecha,
                    Tasa = o.Tasa,
                    MontoDescontado = o.MontoDescontado,
                    TEA = o.TEA,
                    TCEA = o.TCEA,
                    FacturaId = o.FacturaId,
                    Factura = o.Factura,
                    Serie = o.Factura.Serie,
                    BancoId = o.BancoId,
                    Banco = o.Banco,
                    NombreBanco = o.Banco.Nombre
                });
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public float getTceaTotal(int usuarioId)
        {
            try
            {
                var result = context.Descuentos
                .Include(t => t.Factura)
                .Include(t => t.Banco)
                .Where(x => x.Factura.UsuarioId == usuarioId)
                .ToList();

                return result.Sum(x => x.TCEA)/result.Count();
            }
            catch
            {
                throw;
            }
        }

        public bool Save(Descuento entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Descuento entity)
        {
            try
            {
                var DescuentoOriginal = context.Descuentos.Single(
                    x => x.Id == entity.Id
                );

                DescuentoOriginal.Id = entity.Id;
                DescuentoOriginal.Fecha = entity.Fecha;
                DescuentoOriginal.Tasa = entity.Tasa;
                DescuentoOriginal.MontoDescontado = entity.MontoDescontado;
                DescuentoOriginal.TEA = entity.TEA;
                DescuentoOriginal.TCEA = entity.TCEA;
                DescuentoOriginal.FacturaId = entity.FacturaId;
                DescuentoOriginal.BancoId = entity.BancoId;

                context.Update(DescuentoOriginal);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}