﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace ProductService.Infrastructure
{
    public partial class ContextModel
    {
        partial void Initialize()
        {
            var personalManagement = PersonalManagementEntityType.Create(this);
            var visitors = VisitorsEntityType.Create(this);

            PersonalManagementEntityType.CreateAnnotations(personalManagement);
            VisitorsEntityType.CreateAnnotations(visitors);

            AddAnnotation("ProductVersion", "6.0.5");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}