//using AutoMapper;
//using DeviceStore.Data;
//using DeviceStore.Models;
//using Microsoft.AspNetCore.JsonPatch;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using static System.Reflection.Metadata.BlobBuilder;

//namespace DeviceStore.Repositories
//{
//    public class MobileRepository : IMobileRepository
//    {
//        private readonly MobileContext _context;
//        private readonly IMapper _mapper;

//        public MobileRepository(MobileContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        public async Task<List<Mobile>> GetAllMobilesAsync()
//        {
//            var records = await _context.Mobiles.ToListAsync();
//            return _mapper.Map<List<Mobile>>(records);
//        }

//        public async Task<Mobile> GetMobilesByIdAsync(int MobileId)
//        {
//            //var records = await _context.Books.Where(x => x.Id == bookId).Select(x => new BookModel()
//            //{
//            //    Id = x.Id,
//            //    Title = x.Title,
//            //    Description = x.Description
//            //}).FirstOrDefaultAsync();

//            //return records;

//            var mobile = await _context.Mobiles.FindAsync(MobileId);
//            return _mapper.Map<Mobile>(mobile);
//        }

//        public async Task<int> AddMobileAsync(Mobile bookModel)
//        {
//            var book = new Mobile()
//            {
//                Model=bookModel.Model,
//                Ram=bookModel.Ram,
//                Cost=bookModel.Cost
                
//            };

//            _context.Mobiles.Add(book);
//            await _context.SaveChangesAsync();

//            return book.MobileId;
//        }

//        public async Task UpdateMobileAsync(int bookId, Mobile bookModel)
//        {
//            //var book = await _context.Books.FindAsync(bookId);
//            //if (book != null)
//            //{
//            //    book.Title = bookModel.Title;
//            //    book.Description = bookModel.Description;

//            //    await _context.SaveChangesAsync();
//            //}

//            var book = new Mobile()
//            {
//                MobileId = bookId,
//                Model=bookModel.Model,
//                Ram = bookModel.Ram,
//                Cost=bookModel.Cost
                
//            };

//            _context.Mobiles.Update(book);
//            await _context.SaveChangesAsync();
//        }

//        public async Task UpdateMobilePatchAsync(int bookId, JsonPatchDocument bookModel)
//        {
//            var book = await _context.Mobiles.FindAsync(bookId);
//            if (book != null)
//            {
//                bookModel.ApplyTo(book);
//                await _context.SaveChangesAsync();
//            }
//        }

//        public async Task DeleteMobileAsync(int bookId)
//        {
//            var book = new Mobile() { MobileId = bookId };

//            _context.Mobiles.Remove(book);

//            await _context.SaveChangesAsync();
//        }
//        }
//    }

