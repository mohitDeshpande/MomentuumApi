using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MomentuumApi.Model.CivicTrack;
using Microsoft.AspNetCore.Authorization;
using MomentuumApi.Utils;
using System.IO;

namespace MomentuumApi.Controllers
{
    [Produces("application/json")]
    [Route("api/File")]
    public class FileController : Controller
    {
        private readonly CivicTrackContext _context;

        public FileController(CivicTrackContext context)
        {
            _context = context;
        }

        // GET: api/File
        [HttpGet, Authorize]
        public IEnumerable<TblFiles> GetTblFiles()
        {
            return _context.TblFiles;
        }


        // GET: api/file/image{id}
        [Route("image/{id}")]
        [HttpGet, Authorize]
        public  IActionResult GetImageFile([FromRoute] int? id)
        {
            

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (FileHelper.FromDB == true)
            {
                var file = _context.TblFileStore.Where(i => i.Id.Equals(id)).SingleOrDefault();

                if (file == null)
                {
                    return NotFound();
                }


                else
                {
                    try
                    {

                        Byte[] imgBytes = file.File;
                        
                        if (imgBytes != null)
                        {
                            MemoryStream ms = new MemoryStream(imgBytes);
                            return new FileStreamResult(ms, file.FileType);
                        }

                        

                    }
                    catch (Exception ex)
                    {

                        return NotFound();
                    }

                }
            }
            else
            {
                var file = _context.TblFiles.Where(i => i.Id.Equals(id)).SingleOrDefault();


                if (file == null)
                {
                    return NotFound();
                }


                else
                {
                    try
                    {
                        var image =  System.IO.File.OpenRead(FileHelper.BasePath + file.FileName);
                        return File(image, "image/jpeg");
                    }
                    catch (Exception ex)
                    {
                        return NotFound();
                    }

                }
            }
           
            return NotFound();

        }

        // GET: api/File/5
        [HttpGet("{id}"), Authorize]
        public async Task<IActionResult> GetTblFiles([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblFiles = await _context.TblFiles.SingleOrDefaultAsync(m => m.Id == id);

            if (tblFiles == null)
            {
                return NotFound();
            }

            return Ok(tblFiles);
        }

        // PUT: api/File/5
        [HttpPut("{id}"), Authorize]
        public async Task<IActionResult> PutTblFiles([FromRoute] int? id, [FromBody] TblFiles tblFiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblFiles.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblFiles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblFilesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/File
        [HttpPost, Authorize]
        public async Task<IActionResult> PostTblFiles([FromBody] TblFiles tblFiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TblFiles.Add(tblFiles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblFiles", new { id = tblFiles.Id }, tblFiles);
        }

        // DELETE: api/File/5
        [HttpDelete("{id}"), Authorize]
        public async Task<IActionResult> DeleteTblFiles([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblFiles = await _context.TblFiles.SingleOrDefaultAsync(m => m.Id == id);
            if (tblFiles == null)
            {
                return NotFound();
            }

            _context.TblFiles.Remove(tblFiles);
            await _context.SaveChangesAsync();

            return Ok(tblFiles);
        }

        private bool TblFilesExists(int? id)
        {
            return _context.TblFiles.Any(e => e.Id == id);
        }
    }
}