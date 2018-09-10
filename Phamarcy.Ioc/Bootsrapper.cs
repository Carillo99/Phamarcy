using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Phamarcy.Ioc
{
    public static class Bootsrapper
    {
        public static void Ioc(this IServiceCollection services)
        {
            #region Repositorio
            LoadRepository(services);
            #endregion
        }

        private static void LoadRepository(this IServiceCollection services)
        {
            //services.AddTransient<IAndamentoExecucaoProvisoriaRepository, AndamentoExecucaoProvisoriaRepository>();
            //services.AddTransient<IAndamentoProcessoRepository, AndamentoProcessoRepository>();
            
        }
    }
}
