using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Karatsuba
    {
        #region Propiedades
        /// <summary>
        /// Propiedades de la multiplicacion
        /// </summary>
        private Int64 _multiplicando;

        private Int64 _multiplicador;

        #endregion
        #region Metodos
        /// <summary>
        /// Retorma el valor de la operación
        /// </summary>
        /// <returns></returns>
        public Int64 calcular(Int64 multiplicando, Int64 multiplicador)
        {
            this._multiplicando = multiplicando;
            this._multiplicador = multiplicador;
            Int64 respuesta = 0;
            int posicion = Math.Max(_multiplicando.ToString().Length, _multiplicador.ToString().Length);
            if (posicion < 1000)
            {
                return _multiplicando * _multiplicador;
            }
            posicion /= 2;
            Int64 mdo1 = _multiplicando >> posicion;
            Int64 mdo2 = _multiplicando - (mdo1 << posicion);
            Int64 mdor1 = _multiplicador >> posicion;
            Int64 mdor2 = _multiplicador - (mdor1 << posicion);

            Int64 z2 = calcular (mdo1, mdor1);
            Int64 z0 = calcular(mdo2, mdor2);
            Int64 z1 = calcular(mdo1 + mdo2, mdor1 + mdor2);
 
            respuesta = z2 + ((z1 -z2 - z0) << posicion) + (z0 << (2 * posicion));
            return respuesta;
        }
        #endregion
    }
}
