using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.PermissonList
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
        }
        public static class Product
        {
            public const string Read = "Permissions.Product.Read";
            public const string Create = "Permissions.Product.Create";
            public const string Update = "Permissions.Product.Update";
            public const string Delete = "Permissions.Product.Delete";
        }

        public static class Category
        {
            public const string Read = "Permissions.Category.Read";
            public const string Create = "Permissions.Category.Create";
            public const string Update = "Permissions.Category.Update";
            public const string Delete = "Permissions.Category.Delete";
        }

    }
}
