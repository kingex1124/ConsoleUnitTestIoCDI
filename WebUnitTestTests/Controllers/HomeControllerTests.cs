using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebUnitTest.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebUnitTest.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            //arrange
            HomeController target = new HomeController();
            //XXXDataModel dataResult = new XXXDataModel()
            //{
            //    Name = "TestName",
            //    ParentID = 1
            //};

            // act
            //var result = target.Index(dataResult) as ViewResult;

            // assert
            // 回傳ViewResult的寫法
            //Assert.AreEqual(((XXXViewModel)result.Model).ModelAttribute, dataResult);
            // 比對Controller Url的寫法
            //Assert.IsTrue(string.IsNullOrEmpty(result.ViewName) || result.ViewName == "Index");
        }
    }

    // 以下皆為參考範本
    //IFunctionItemService functionItemService = MockRepository.GenerateStub<IFunctionItemService>();
    //IFunctionItemBO functionItemBO = MockRepository.GenerateStub<IFunctionItemBO>();

    //[TestMethod()]
    //public void IndexTest()
    //{
    //    //arrange
    //    FunctionItemController target = new FunctionItemController(functionItemService, functionItemBO);
    //    FunctionItemCriteria filter = new FunctionItemCriteria()
    //    {
    //        Name = "TestName",
    //        ParentID = 1
    //    };

    //    List<FunctionItem> resultData = new List<FunctionItem>() {
    //            new FunctionItem() { Id = 1, Name = "A", ControllerName = "FunctionItem", Sort = 1 },
    //        };

    //    functionItemService.Stub(o => o.FindAll(Arg<Expression<Func<FunctionItem, bool>>>.Is.Anything)).Return(resultData);
    //    // act
    //    var result = target.Index(filter) as ViewResult;
    //    // assert
    //    Assert.AreEqual(((FunctionItemViewModel)result.Model).Filter, filter);
    //    Assert.IsTrue(string.IsNullOrEmpty(result.ViewName) || result.ViewName == "Index");
    //}

    // 以下參考範本
    //[TestMethod()]
    //public void IndexTest1()
    //{
    //    //arrange       
    //    FunctionItemController target = new FunctionItemController(functionItemService, functionItemBO);
    //    FunctionItemCriteria filter = new FunctionItemCriteria()
    //    {
    //        Name = "TestName",
    //        ParentID = 1
    //    };

    //    FunctionItemSearchModel goal = new FunctionItemSearchModel()
    //    {
    //        ResultData = new List<FunctionItemData>()
    //             {
    //                new FunctionItemData(){ ID = 1 , Name = "A" , ControllerName = "FunctionItem", Sort = 1},
    //                new FunctionItemData(){ ID = 2 , Name = "B" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1},
    //                new FunctionItemData(){ ID = 3 , Name = "C" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1},
    //                new FunctionItemData(){ ID = 4 , Name = "D" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1},
    //                new FunctionItemData(){ ID = 5 , Name = "E" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1}
    //             },
    //        TableMaxPage = 3
    //    };

    //    List<FunctionItem> resultData = new List<FunctionItem>() {
    //            new FunctionItem() { Id = 1, Name = "A", ControllerName = "FunctionItem", Sort = 1 },
    //            new FunctionItem() { Id = 2, Name = "B", ControllerName = "FunctionItem", ParentId = 1, Sort = 1 },
    //            new FunctionItem() { Id = 3, Name = "C", ControllerName = "FunctionItem", ParentId = 1, Sort = 1 },
    //            new FunctionItem() { Id = 4, Name = "D", ControllerName = "FunctionItem", ParentId = 1, Sort = 1 },
    //            new FunctionItem() { Id = 5, Name = "E", ControllerName = "FunctionItem", ParentId = 1, Sort = 1 }
    //        };

    //    List<FunctionItemData> resultViewData = new List<FunctionItemData>()
    //        {
    //            new FunctionItemData(){ ID = 1 , Name = "A" , ControllerName = "FunctionItem", Sort = 1},
    //            new FunctionItemData(){ ID = 2 , Name = "B" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1},
    //            new FunctionItemData(){ ID = 3 , Name = "C" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1},
    //            new FunctionItemData(){ ID = 4 , Name = "D" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1},
    //            new FunctionItemData(){ ID = 5 , Name = "E" , ControllerName = "FunctionItem", ParentId = 1, Sort = 1}
    //        };

    //    // take
    //    functionItemBO.Stub(o => o.GetTableTakeCount()).Return(2);
    //    // count
    //    functionItemBO.Stub(o => o.GetFunctionItemCount(Arg<FunctionItemCriteria>.Is.Anything)).Return(5);

    //    functionItemService.Stub(o => o.FindAll(Arg<Expression<Func<FunctionItem, bool>>>.Is.Anything)).Return(resultData);
    //    // dbData
    //    functionItemBO.Stub(o => o.GetFilterData(Arg<FunctionItemCriteria>.Is.Anything, Arg<string>.Is.Anything, Arg<string>.Is.Anything, Arg<int>.Is.Anything, Arg<int>.Is.Anything)).Return(resultData);

    //    functionItemBO.Stub(o => o.SettingFunctionItemDataResultData(Arg<List<FunctionItem>>.Is.Anything)).Return(resultViewData);
    //    // act
    //    var testResult = target.Index(filter, 1, "Test", "True");

    //    var result = (FunctionItemSearchModel)(((JsonResult)testResult).Data);

    //    //assert
    //    for (int i = 0; i < result.ResultData.Count; i++)
    //    {
    //        Assert.AreEqual(result.ResultData[i].ID, goal.ResultData[i].ID);
    //        Assert.AreEqual(result.ResultData[i].Name, goal.ResultData[i].Name);
    //        Assert.AreEqual(result.ResultData[i].ControllerName, goal.ResultData[i].ControllerName);
    //        Assert.AreEqual(result.ResultData[i].ParentId, goal.ResultData[i].ParentId);
    //        Assert.AreEqual(result.ResultData[i].Sort, goal.ResultData[i].Sort);
    //    }

    //    Assert.AreEqual(result.TableMaxPage, goal.TableMaxPage);
    //}
}