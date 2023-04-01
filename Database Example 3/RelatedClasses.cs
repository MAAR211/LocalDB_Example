//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using Database_Example_3.Models;
//using DependencyInjectionExample;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Configuration.Json;
//using Database_Example_3.Models;
//using System.Runtime.CompilerServices;

//namespace Database_Example_3
//{
//    public class RelatedClasses
//    {



//        public void JobseekerRelatedClasses()
//        {
//            //        Assembly assembly = Assembly.GetExecutingAssembly();
//            //        var typesWithJobseekerId = assembly.GetTypes()
//            //            .Where(t => !t.IsAnonymousType() && t.GetProperties()
//            //                .Any(p => p.Name == "JobseekerId"));

//            //        foreach (var type in typesWithJobseekerId)
//            //        {
//            //            Console.WriteLine($"Type with JobseekerId property: {type.FullName}");
//            //        }
//            //    }
//            //}

//            //public static class TypeExtensions
//            //{
//            //    public static bool IsAnonymousType(this Type type)
//            //    {
//            //        return Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
//            //               && type.IsGenericType && type.Name.Contains("AnonymousType")
//            //               && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$"))
//            //               && type.Attributes.HasFlag(TypeAttributes.NotPublic);
//            //    }
//            //}





//            //{
//            //        Assembly assembly = Assembly.GetExecutingAssembly();
//            //        var typesWithJobseekerId = assembly.GetTypes()
//            //.Where(t => t.GetProperties()
//            //    .Any(p => p.Name == "JobseekerId"));

//            //        foreach (var type in typesWithJobseekerId)
//            //        {
//            //            Console.WriteLine($"Type with JobseekerId property: {type.FullName}");

//            //            // Check if the type has a relationship with the anonymous types
//            //            var relatedTypes = assembly.GetTypes()
//            //                .Where(t => t.GetProperties()
//            //                    .Any(p => p.PropertyType == type && p.Name.EndsWith("Id")));

//            //            foreach (var relatedType in relatedTypes)
//            //            {
//            //                Console.WriteLine($"  - Related type: {relatedType.FullName}");
//            //            }
//            //        }












////aqedan


//            Assembly assembly = Assembly.GetExecutingAssembly();
//            var typesWithJobseekerId = assembly.GetTypes()
//             .Where(t => t.GetProperties()
//          .Any(p => p.Name == "JobseekerId"));

//            foreach (var type in typesWithJobseekerId)
//            {
//                Console.WriteLine($"Class has a JobseekerId property:         {type.Name}         ");


//                ////    check base types of the type
//                //    var baseType = type.BaseType;
//                //    while (baseType != null)
//                //    {
//                //        Console.WriteLine($" - Base type: {baseType.Name}");
//                //        baseType = baseType.BaseType;
//                //    }

//            }



//        }

//    }
//}
    

