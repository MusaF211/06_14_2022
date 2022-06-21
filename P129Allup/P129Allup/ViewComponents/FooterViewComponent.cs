using Microsoft.AspNetCore.Mvc;
using P129Allup.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129Allup.ViewComponents
{
    public class FooterViewComponent
    {

        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(IDictionary<string, string> settings)
        {
            //IDictionary<string, string> settings = await _context.Settings.ToDictionaryAsync(x => x.Key, s => s.Value);

            return View(await Task.FromResult(settings));
        }

        private IViewComponentResult View(IDictionary<string, string> dictionary)
        {
            throw new NotImplementedException();
        }
    }
}
