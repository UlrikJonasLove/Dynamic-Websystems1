using System;
using Xunit;
using Bageriet.Models;
using Bageriet.Controllers;
using Bageriet.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bageriet.Test
{
    public class BagerietXunit
    {
        [Fact]

        public void ListViewModelNotNull()
        {
            ProductListViewModel listViewModel = new ProductListViewModel();

            Assert.NotNull(listViewModel);
        }

        [Fact]
        public void HomeViewmodelNotNull()
        {
            HomeViewModel homeViewModel = new HomeViewModel();


            Assert.NotNull(homeViewModel);
        }

        [Fact]
        public void Test2()
        {
            var controller = new ContactController();
            var result = new ContactController();

            Assert.NotEqual(controller, result);
        }
    }
}

