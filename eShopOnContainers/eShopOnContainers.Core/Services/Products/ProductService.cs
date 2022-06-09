﻿using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Helpers;
using eShopOnContainers.Core.Models.Product;
using eShopOnContainers.Core.Services.FixUri;
using eShopOnContainers.Core.Services.RequestProvider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Products
{
    public class ProductService : IProductsService
    {


        private readonly IRequestProvider _requestProvider;
        private readonly IFixUriService _fixUriService;

        private const string ApiUrlBase = "products";

        public IEnumerable<Product> LocalBasketItems { get; set; }
        public ProductService(IRequestProvider requestProvider, IFixUriService fixUriService)
        {
            _requestProvider = requestProvider;
            _fixUriService = fixUriService;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {

            var uri = UriHelper.CombineUri(GlobalSetting.Instance.GatewayShoppingEndpoint,ApiUrlBase);


            IEnumerable<Product> items = await _requestProvider.GetAsync<IEnumerable<Product>>(uri);

            if (items != null)
                return items?.ToObservableCollection();
            else
                return new ObservableCollection<Product>();

            //// Create HttpClient
            //var client = new HttpClient { BaseAddress = new Uri("https://englishhome.azurewebsites.net/api/") };

            //// Assign default header (Json Serialization)
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue( "application/json"));

            //// Make an API call and receive HttpResponseMessage
            //var result = await((await client.GetAsync("products", HttpCompletionOption.ResponseContentRead)).Content.ReadAsStringAsync());
            //Console.WriteLine(result);
            //// Convert the HttpResponseMessage to string
            ////var resultArray = await responseMessage.Content.ReadAsStringAsync();

            //// Deserialize the Json string into type using JsonConvert
            //var personList = JsonConvert.DeserializeObject<List<Product>>(result);
            //return personList;
        }
    }
}