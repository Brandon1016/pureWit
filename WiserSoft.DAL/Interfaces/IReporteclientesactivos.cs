﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiserSoft.DATA;

namespace WiserSoft.DAL.Interfaces
{
    public interface IReporteclientesactivos
    {
        List<Reporteclientesactivos> ListarReporteclientesactivos();
        Reporteclientesactivos BuscarReporteclientesactivos(int id_contacto);
    }
}
