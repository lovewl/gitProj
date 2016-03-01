<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detectionProcess.aspx.cs" Inherits="wxtest.UILayer.AirConditioningPages.detectionProcess" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="format-detection" content="telephone=no" />
    <title>西安交通事故快处快赔服务中心</title>
    <link href="/assets/css/mian.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        a:link {
            font-size: 24px;
            color: #337FE5;
            text-decoration: none;
        }

        a:visited {
            font-size: 24px;
            color: #337FE5;
            text-decoration: none;
        }

        a:hover {
            font-size: 24px;
            color: #999999;
            text-decoration: underline;
        }

        body {
            background: #E0E0E0;
        }

        .divall {
            border: 0px solid green;
            padding: 10px 6px 10px 8px;
        }

        .divimg {
            border: 0px solid #ccc;
        }

        .divtitle {
            margin-top: 2px;
            border: 0px solid red;
        }

        .divtime {
            margin-top: 2px;
            border: 0px solid red;
        }

        .titlespan {
            color: #ff9900;
            font-size: 18px;
        }

        .titlestarspan {
            color: #ff9900;
            font-size: 18px;
            text-align: right;
        }

        .timespan {
            color: #666;
        }

        .divcontent {
            margin-top: 5px;
            border: 0px solid red;
        }

        .divbtn {
            margin-top: 10px;
            border: 0px solid red;
        }

        .btnspan {
            color: #666;
        }

        div.RoundedCorner {
            background: #FFFFFF;
            margin-left: 8px;
            margin-right: 8px;
            margin-top: 8px;
            margin-bottom: 8px;
        }

        b.rtop, b.rbottom {
            display: block;
            background: #E0E0E0;
        }

            b.rtop b, b.rbottom b {
                display: block;
                height: 1px;
                overflow: hidden;
                background: #FFFFFF;
            }

        b.r1 {
            margin: 0 5px;
        }

        b.r2 {
            margin: 0 3px;
        }

        b.r3 {
            margin: 0 2px;
        }

        b.rtop b.r4, b.rbottom b.r4 {
            margin: 0 1px;
            height: 2px;
        }
    </style>
</head>
<body style="padding-top:0">
    <div class="RoundedCorner">
        <b class="rtop"><b class="r1"></b><b class="r2"></b><b class="r3"></b><b class="r4"></b></b>
        <div class="zhezhao"></div>
        <div class="nav">
            <h1>网站导航</h1>
            <ul>
                <li><a href="/UILayer/FastClaims.aspx">快速理赔</a></li>
                <li><a href="/UILayer/shanxiyongjiu.aspx">陕西永久</a></li>
                <li><a href="/UILayer/AirConditioning.aspx">空调专修</a></li>
            </ul>
        </div>
        <p style="text-align: center;">
            <a href="/UILayer/AirConditioningPages/detectionProcess.aspx">
                <img style="width: 100%" src="/images/web/air103.jpg" alt="" height="200" /></a>
        </p>
        <div class="divall">
            <div class="divtitle" style="border: 0px solid red; font-family: Simsun; font-size: medium; background-color: #FFFFFF;">
                <span class="titlespan" style="color: #FF9900; font-size: 18px;">汽车空调18项检测、36点检查</span><span class="titlestarspan" style="color: #FF9900; font-size: 18px;"></span>
            </div>
            <div class="divtime" style="border: 0px solid red; font-family: Simsun; font-size: medium; background-color: #FFFFFF;">
                <span runat="server" class="timespan" style="color: #666666;"><%= DateStr %></span>
            </div>
            <div class="rich_media_content" id="js_content">
                <p style="">
                    <img data-s="300,640" data-type="jpeg" data-src="http://mmbiz.qpic.cn/mmbiz/qfBeGNVpnqv7LsFV2X2Ar837DcE41R1dGfLeTZnEU9w2oKIInCgnmGdoAgFedJ1tg4KTauF8KdcJTPYYbjRF7A/0" data-ratio="0.66600790513834" data-w="" /><br />
                </p>
                <p style="">天气炎热，如果在这个时候汽车的空调坏了，可想而知，蒸笼一样的汽车简直无法让人忍受。看似一个简单的空调问题，把车开到修理店检查维修，有些毛病屡次修却没有修好，到底是哪里出了问题？想要知道正规修理店的空调检测程序吗？请看下文：</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style=""><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(255, 0, 0); box-sizing: border-box !important; word-wrap: break-word !important;">一、夏季空调不凉的后果：</span></p>
                <p style="">1、新车空调不凉：</p>
                <p style="">购买的新车，汽车空调的制冷功能就一直没用过，入夏后开车比较少，也没有发现车辆出毛病。最近气温升高，打开空调后发现制冷效果不明显。把车送到维修店后，添加制冷剂、检查空调压缩机，花了将近千元钱也没有把空调不凉的毛病彻底解决。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">2、老车空调不制冷：</p>
                <p style="">车辆已经快五年了，行驶也近15万公里，属于典型的老年车了，现在空调效能越来越差，打开空调，虽然感觉风呼呼的吹，空调风噪音非常大，但是车内温度却降不下来，而且油耗也高达十几个降不下来。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style=""><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(255, 0, 0); box-sizing: border-box !important; word-wrap: break-word !important;">二、汽车空调不凉的原因：</span></p>
                <p style="">空调不凉分完全不制冷、制冷效果差等这些原因，而且导致这一现象也是由很多情况引起的，不要盲目的下判断，要根据正规空调检测流程来做出判断再进行维修。</p>
                <p style="">1、 氟的质量与纯度。</p>
                <p style="">氟的质量与纯度在车载空调中起到了至关重要的作用，通常劣质的氟会导致空调运转效率低下。</p>
                <p style="">2、 冷凝器与水箱。</p>
                <p style="">冷凝器与水箱的散热情况也会影响空调的使用，长时间不清理会导致冷凝器与水箱被异物灰尘所覆盖。</p>
                <p style="">3、 氟的使用。</p>
                <p style="">很多车主认为空调中的氟越多越好，其实并非这样。在加氟过程中，氟的量既不可多也不可少。少了会使空调管内压力不够，多了则压力过大。以上两种情况下，空调都无法正常运转制冷。</p>
                <p style="">4、 膨胀阀的质量。</p>
                <p style="">膨胀阀是制冷系统中的一个重要部件，一般安装于储液筒和蒸发器之间。劣质的膨胀阀会使制冷剂起不到应有的作用。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style=""><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(255, 0, 0); box-sizing: border-box !important; word-wrap: break-word !important;">三、汽车空调服务检测完全流程：</span></p>
                <p style="">（一）空调整体性检查：</p>
                <p style="">1、 冷凝器散热器外观检查：</p>
                <p style="">检查目的：检查是否堵塞、是否损伤；冷凝器表面是否油污、是否泄露；散热器是否泄漏。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">2、 冷却液检测：</p>
                <p style="">检查目的：检查冷却液液位是否正常、是否浑浊；防冻液PH值小于7.5则酸性过强，很容易损伤水箱内的金属；PH值大于9，碱性过强，容易使缓蚀剂出并生成沉淀，失去防腐作用。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">3、 空调压缩机皮带检查。</p>
                <p style="">检查目的：检查是否裂损、松紧度是否正常。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">4、 异响检查：</p>
                <p style="">检查目的：皮带张紧轮是否有异响、压缩机是否有异响。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">5、 空调制冷系统部件工作性能（可以用空调系统湿度分析法）：</p>
                <p style="">检查目的：检查压缩机两侧的温差、冷凝器两侧的温差等。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">6、 制冷剂纯度：</p>
                <p style="">检查目的：检查R134A、R12、R22、AIR的纯度，借助仪器进行。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">7、 空调系统压力：</p>
                <p style="">检查目的：检查环境温度、高压侧压力、低压侧压力。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">8、 空调系统线路：</p>
                <p style="">检查目的：检查是否老化裂损、插接件连接是否固定牢固</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">9、 空调制冷系统：</p>
                <p style="">检查目的：检查空调管路接口是否渗漏、压缩机本体组装接口是否损坏。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">10、 隔热装置检查：</p>
                <p style="">检查目的：检查机舱隔热板是否破损、排风管及消音器隔热板是否损坏；隔热板损坏和缺失会导致车内温度升高。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">（二）车内空调送风部分检查：</p>
                <p style="">11、 空调控制功能检查：</p>
                <p style="">检查目的：检查空调各面板各功能开关是否正常。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">12、 鼓风机：</p>
                <p style="">检查目的：检查鼓风机是否工作正常、是否有异响。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">13、送风模式检查：</p>
                <p style="">检查目的：检查中间出风模式、风挡玻璃除霜除雾模式、直排下部通风模式、后部空调出风模式、出风口是否损坏等。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">14、风量检测：</p>
                <p style="">检查目的：检查风量开关至二档、风量开至最大时的风量检查，主要是为了检查空调滤芯、蒸发器堵塞情况。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">15、出风口温度检测：</p>
                <p style="">检查目的：检查风速最大、风量二挡、通风模式开至内循环等几个温度值。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">16、异味检测：</p>
                <p style="">检查目的：检查是否有异味，异味所处的位置。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">17、空调滤清器检测：</p>
                <p style="">检查目的：检查滤清器是否脏污、堵塞</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">18、诊断仪检测故障查询：</p>
                <p style="">检查目的：检查空调系统是否正常、发动机系统是否正常，需借助仪器。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style=""><span style="margin: 0px; padding: 0px; max-width: 100%; color: rgb(255, 0, 0); box-sizing: border-box !important; word-wrap: break-word !important;">四、夏季空调使用注意事项:</span></p>
                <p style="">1、 不在车内开空调睡觉。</p>
                <p style="">夏日出门很多时候是不是想在车上美美滴睡上一觉呢?千万不要这样做!切记!汽车尾气排放的一氧化碳无法在封闭的汽车空间里及时排掉，很容易导致有毒气体渗入车内。这毒气可是危机生命的！</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">2、汽车空调要及时清洗。</p>
                <p style="">爱车就不要偷懒，每年春季过后更换一次滤芯，并且要清洗汽车空调冷凝器，清洗要彻底，最好将水箱拆下来洗。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">3、汽车空调出风口方向控制要合理。</p>
                <p style="">开冷气时将出风口向上，开暖气时将出风口向下。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">4、汽车空调开启时间别太长。</p>
                <p style="">长时间使用汽车空调会使冷凝器压力过大，这会对制冷系统造成损耗。因此在车内温度已经让你怡然自得的时候，不妨将汽车空调关闭一会儿。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">5、适当开启汽车空调大风量。</p>
                <p style="">汽车空调使用时会吸入很多灰尘，定期开大风能将风道内表面的浮尘吹出来，这个方法最简单有效。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">6、低速行驶时关闭汽车空调。</p>
                <p style="">低速行驶时尽量关闭空调，遇到堵车时不要为提高汽车空调效能而使发动机以较高转速运转，这样会缩短发动机和空调压缩机的使用寿命。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">7、汽车空调开关程序要牢记。</p>
                <p style="">开机时，先开风扇开关，再开压缩机开关(A/C)，关机时，先关压缩机开关(A/C)，再关风扇开关。最好在高温时关掉压缩机开关后，两三分钟再关风扇，这样能让空调压缩机更好地散热。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">8、汽车空调内外循环要掌握。</p>
                <p style="">经过暴晒后，车内温度很高，应该先开着车门，用外循环放放热气。等温度下降后，内循环模式下制冷效果更好。好的，今天就给大家分享这些了。祝大家生活愉快。</p>
                <p style="">
                    <br style="margin: 0px; padding: 0px; max-width: 100%; box-sizing: border-box !important; word-wrap: break-word !important;" />
                </p>
                <p style="">总结：汽车空调不凉的原因有哪几种?汽车空调不凉，不要盲目加氟，要先判断是否缺氟。没有经验的车主，最好到专业汽车维修厂加氟，尽量不要自己操作，否则会导致汽车空调管路里的氟超标和系统散热不良，汽车空调自然也就不凉了。</p>
                <strong><span style="font-family: 宋体;">------------------------------------</span></strong><p style="color: #3E3E3E;">
                    <strong><span style="font-family: 宋体;">陕西永久汽车服务有限公司</span></strong>
                </p>
                <p style="color: #3E3E3E;">
                    <strong><span style="font-family: 宋体;">中国一汽特约维修服务中心</span></strong>
                </p>
                <p style="color: #3E3E3E;">
                    <strong>陕西永久汽车空调专业服务站</strong>
                </p>
                <p style="color: #3E3E3E;">
                    <strong><span style="color: #0070C0;">地址</span></strong><span style="color: #0070C0;">：</span><span style="color: #3366FF;">西安市未央区明光路南段</span><span style="font-family: Verdana, sans-serif; color: #3366FF;">3</span><span style="color: #3366FF;">号《交通事故快速理赔中心（北郊永久点）》</span>
                </p>
                <p style="color: #3E3E3E;">
                    <strong><span style="font-family: 宋体; color: #0070C0;">电话</span></strong><span style="font-family: 宋体; color: #0070C0;">：</span><strong><span style="font-family: Arial, sans-serif; color: #3366FF;"><a href="tel:02986220693">029-86220693</a></span></strong><span style="font-family: Arial, sans-serif; color: #0070C0;"> </span><strong><span style="font-family: Arial, sans-serif; color: #3366FF;"></span><span style="color: #3366FF;"><a href="tel:18192933995">18192933995</a></span></strong>
                </p>
                <p style="color: #3E3E3E;">
                    <span style="font-family: Arial, sans-serif;"></span>
                </p>
                <p style="color: #3E3E3E;">
                    <strong><span style="color: #0070C0;">官方微信</span></strong><span style="color: #0070C0;">：</span><span style="font-family: Arial, sans-serif; color: #0070C0;">yj86220693</span>
                </p>
                <p style="color: #3E3E3E;">
                    <strong><span style="color: #0070C0;">网址</span></strong><span style="color: #0070C0;">：</span><span style="font-family: Arial, sans-serif; color: #0070C0;"><a href="http://www.yongjiu.co">www.yongjiu.co</a></span>
                </p>
                <br />
            </div>
            <!--pj-->
            <div class="divbtn"><span class="btnspan"><a href="###"></a></span></div>
        </div>
        <b class="rbottom"><b class="r4"></b><b class="r3"></b><b class="r2"></b><b class="r1"></b></b>
    </div>
    <footer><a href="javascript:history.back()" id="fanhui"></a><a href="/index.aspx" id="home"></a><a href="javascript:void(null)" id="list"></a><a href="tel:02986220693" id="tel"></a><a href="http://map.baidu.com/mobile/webapp/index/index/foo=bar/vt=map" id="map"></a></footer>
    <script type="text/javascript" src="/assets/js/zepto.min.js"></script>
    <script type="text/javascript" src="/assets/js/banner.js"></script>
    <script type="text/javascript" src="/assets/js/touchslider.dev.js"></script>
    <script type="text/javascript" src="/assets/js/fastclick.js"></script>
</body>
</html>
