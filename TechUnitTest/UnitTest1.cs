using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using AutoMapperDemo;
using System.Collections.Generic;

namespace TechUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer
            {
                Name = "George Costanza"
            };
            var order = new Order
            {
                Customer = customer
            };
            var bosco = new Product
            {
                Name = "Bosco",
                Price = 4.99m
            };
            order.AddOrderLineItem(bosco, 15);

            // Configure AutoMapper

            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDto>());

            // Perform mapping

            OrderDto dto = Mapper.Map<Order, OrderDto>(order);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Model
            var calendarEvent = new CalendarEvent
            {
                Date = new DateTime(2008, 12, 15, 20, 30, 0),
                Title = "Company Holiday Party"
            };

            // Configure AutoMapper
            Mapper.Initialize(cfg =>
              cfg.CreateMap<CalendarEvent, CalendarEventForm>()
                .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.Date.Date))
                .ForMember(dest => dest.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
                .ForMember(dest => dest.EventMinute, opt => opt.MapFrom(src => src.Date.Minute)));

            // Perform mapping
            CalendarEventForm form = Mapper.Map<CalendarEvent, CalendarEventForm>(calendarEvent);

        }

        [TestMethod]
        public void TestMehtod2()
        {
            Mapper.Initialize(cfg =>
                cfg.CreateMap<Source, Destination>()
                .ForMember(dest => dest.SomeValuefff, opt => opt.MapFrom(src => src.SomeValue)));

            Mapper.Configuration.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void TestMethod3()
        {

            Mapper.Initialize(cfg => cfg.CreateMap<Source2, Destination2>());

            var sources = new[]
           {
                new Source2 { Value = 5 },
                new Source2 { Value = 6 },
                new Source2 { Value = 7 }
            };


            IEnumerable<Destination2> ienumerableDest = Mapper.Map<Source2[], IEnumerable<Destination2>>(sources);
            ICollection<Destination2> icollectionDest = Mapper.Map<Source2[], ICollection<Destination2>>(sources);
            IList<Destination2> ilistDest = Mapper.Map<Source2[], IList<Destination2>>(sources);
            List<Destination2> listDest = Mapper.Map<Source2[], List<Destination2>>(sources);
            Destination2[] arrayDest = Mapper.Map<Source2[], Destination2[]>(sources);

        }
    }
}
