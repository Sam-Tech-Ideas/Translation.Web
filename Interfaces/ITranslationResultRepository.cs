using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Translation.Web.Models.Entities;

namespace Translation.Web.Interfaces
{
    public interface ITranslationResultRepository
    {
        Task<IEnumerable<TranslationResult>> GetResults();
    }
}
