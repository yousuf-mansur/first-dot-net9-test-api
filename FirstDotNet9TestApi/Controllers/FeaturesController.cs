using FirstDotNet9TestApi.Data;
using FirstDotNet9TestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstDotNet9TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {

        private readonly FeatureDbContext _db;


        static private List<Feature> features = new List<Feature>
        {
            new Feature { Id = 1, Name = "Cloud-Native Development", Description = "Improved support for Kubernetes, managed database services, and streamlined deployment." },
            new Feature { Id = 2, Name = "Intelligent App Development", Description = "Integration with OpenAI and OSS models for AI-powered applications." },
            new Feature { Id = 3, Name = "Productivity Enhancements", Description = "Enhanced tooling in Visual Studio and improved diagnostics for developers." },
            new Feature { Id = 4, Name = "Performance and Security", Description = "Runtime optimizations and robust security measures, including new cryptographic APIs." },
            new Feature { Id = 5, Name = "TimeSpan Precision Fix", Description = "New TimeSpan.From* overloads to address floating-point precision issues." },
            new Feature { Id = 6, Name = "X.509 Certificate Improvements", Description = "Improved handling of certificates for cross-platform compatibility." },
            new Feature { Id = 7, Name = "OpenSSL and CNG Updates", Description = "Support for modern cryptographic key management and virtualization-based security on Windows." }
        };

        public FeaturesController(FeatureDbContext db)
        {
            _db = db;
        }

        // GET: api/Features
        [HttpGet]
        public async Task<ActionResult<List<Feature>>> GetFeatures()
        {
            var features = await _db.Features.ToListAsync();
            return Ok(features);
        }


        // GET: api/Features/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Feature>> GetFeatureById(int id)
        {
            //var feature= features.FirstOrDefault(f => f.Id == id);
            var feature = await _db.Features.FindAsync(id);
            if (feature == null)
            {
                return NotFound(new { message = "Feature not found" });
            }

            return Ok(feature);
        }



 


        // POST: api/Features
        [HttpPost]
        public async Task<IActionResult> AddFeature([FromBody] Feature newFeature)
        {
            //newFeature.Id = features.Max(f => f.Id) + 1;
            //features.Add(newFeature);


            if (newFeature == null || !ModelState.IsValid)
            {
                return BadRequest(new { message = "Invalid data" });
            }

            await _db.Features.AddAsync(newFeature);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFeatureById), new { id = newFeature.Id }, newFeature);



            //var feature = new Feature
            //{
            //    Name = newFeature.Name,
            //    Description = newFeature.Description

            //};            
            //features.Add(feature);
            //return Ok(new {success=true, message="Feature Created Successfully", feature});
        }


     



        // PUT: api/Features/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFeature(int id, [FromBody] Feature updateFeature)
        {
            //var feature = features.FirstOrDefault(f => f.Id == id);
            if (updateFeature == null || !ModelState.IsValid)
            {
                return BadRequest(new { message = "Invalid data" });
            }

            var feature = await _db.Features.FindAsync(id);
            if (feature == null)
            {
                return NotFound(new { message = "Feature not found" });
            }

            feature.Name = updateFeature.Name;
            feature.Description = updateFeature.Description;

            await _db.SaveChangesAsync();

            return Ok(new { success = true, message = "Feature updated successfully", feature });
        }





        
        // DELETE: api/Features/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            //var feature = features.FirstOrDefault(f => f.Id == id);
            var feature = await _db.Features.FindAsync(id);
            if (feature == null)
            {
                return NotFound(new { message = "Feature not found" });
            }

            _db.Features.Remove(feature);
            await _db.SaveChangesAsync();

            return Ok(new { success = true, message = "Feature deleted successfully" });
        }
    }
}
