var time = require("../../utils/util");

Page({
  data:{
    lists:[
      {
        content:"hello",
        time:Date.now(),
        id:1
      }
    ]
  },
  onLoad(){
    // var arr = wx.getStorageInfoSync('logs');
    // console.log(arr);
    initData(this);
  },
  edit(e){
    console.log('edit ===>')
    //console.log(e);
    var id = e.currentTarget.dataset.id;
    console.log(id);
    wx.navigateTo({
      url: '../add/add?id=' + id
    })
  },
  add(){
    console.log('add ===>')
    wx.navigateTo({
      url: '../add/add',
    })
  }
})
function initData(page){
  var arr = wx.getStorageSync(txt);
  if(arr.leght){
    arr.forEach((item,i) => {
      var t = new Data(Number(item.time));
      item.time = time.formattime(t);
    })
    page.setData({
      lists:arr
    })
  }
}