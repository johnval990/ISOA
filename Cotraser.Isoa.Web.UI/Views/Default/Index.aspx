﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Default.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ISOA
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!--SLIDER-->
    <div class="teaser">
        <div class="container">
            <div class="row">
                <div class="span12 headline">
                    <h1>
                        All solutions start at one place</h1>
                    <small>Sub Header test</small> <i class="description">And this is that place. So, let's
                        get started right away</i>
                </div>
                <!--/span12-->
            </div>
            <!--/row-->
            <div class="row animated fadeInUp">
                <div class="span12">
                    <div id="myCarousel" class="carousel slide">
                        <div class="carousel-inner">
                            <!--slide-->
                            <div class="active item">
                                <div class="row">
                                    <div class="span6">
                                        <img src="../App_Themes/Default/assets/slide-half-1.png" alt="" />
                                    </div>
                                    <div class="span4">
                                        <h2>
                                            Fancy Content Slider</h2>
                                        <p>
                                            Create a merry-go-round of any content you wish to provide an interactive slideshow
                                            of content.</p>
                                        <p>
                                            You can slide pictures, text, labels, videos & html content with little to no effort.
                                            HTML5 Like you, we love building awesome products on the web. We love it so much,
                                            we decided to help people just like us do it easier, better, and faster. Bootstrap
                                            is built for you.</p>
                                        <p>
                                            Place full width images or combine them with text block, links or more images using
                                            Bootstrap grid system.</p>
                                        <a class="btn btn-red" href="#">Awesome!</a>
                                    </div>
                                </div>
                            </div>
                            <!--slide-->
                            <div class="item">
                                <div class="row">
                                    <div class="span6 animated rotateInDownLeft">
                                        <img src="../App_Themes/Default/assets/slide-half-2.png" alt="" />
                                    </div>
                                    <div class="span4 animated rotateInUpRight">
                                        <h2>
                                            56 CSS3 Animations</h2>
                                        <p>
                                            You can do a whole bunch of other stuff with animate.css when you combine it with
                                            jQuery or add your own CSS rules.</p>
                                        <p>
                                            animate.css is a bunch of cool, fun, and cross-browser cool animations for you to
                                            use in your projects. Great for emphasis, home pages, sliders, and general just-add-water-awesomeness.
                                            Dynamically add animations using jQuery with ease.</p>
                                        <p>
                                            Don't hesitate to start creating your own creative work with this top notch feature.</p>
                                        <a class="btn btn-red" href="#">Want to start now?</a>
                                    </div>
                                </div>
                            </div>
                            <!--slide-->
                            <div class="item">
                                <div class="row">
                                    <div class="span6 animated fadeInUpBig">
                                        <img src="../App_Themes/Default/assets/slide-half-3.png" alt="" />
                                    </div>
                                    <div class="span4 animated fadeInDownBig">
                                        <h2>
                                            Customizable Slider</h2>
                                        <p>
                                            Use Bootstrap scaffolding goodness to arrange pictures and text the way you want.</p>
                                        <p>
                                            Place full width images or combine them with text block, links or more images using
                                            Bootstrap grid system.</p>
                                        <a class="btn btn-primary" href="#">Start Now!</a>
                                    </div>
                                </div>
                            </div>
                            <!--slide-->
                            <div class="item animated fadeInUpBig">
                                <img src="../App_Themes/Default/assets/slide-full-1.png" alt="" />
                            </div>
                            <!--slide-->
                            <div class="item">
                                <div class="row">
                                    <div class="span6 animated rotateInDownLeft">
                                        <div class="video-container">
                                            <%--<iframe src="https://player.vimeo.com/video/46992613?title=1&amp;byline=1&amp;portrait=1" width="470" height="580" frameborder="0" webkitAllowFullScreen mozallowfullscreen allowFullScreen></iframe>--%>
                                        </div>
                                    </div>
                                    <div class="span4 animated rotateInUpLeft">
                                        <h2>
                                            Responsive videos</h2>
                                        <p>
                                            Wrap each video in a predefined class container to achieve fluid width videos in
                                            your responsive web design.</p>
                                        <p>
                                            Every video will fit any screen width, inlcuding, desktop computers, tablets, smartphones
                                            and other devices.</p>
                                        <a class="btn btn-info" href="#">Mobile ready!</a>
                                    </div>
                                </div>
                                <!--/row-->
                            </div>
                            <!--/item-->
                        </div>
                        <!--/carousel-inner-->
                        <!-- Carousel nav -->
                        <a class="carousel-control left" href="#myCarousel" data-slide="prev">&lsaquo;</a>
                        <a class="carousel-control right" href="#myCarousel" data-slide="next">&rsaquo;</a>
                    </div>
                    <!--/myCarousel-->
                </div>
                <!--/span12-->
            </div>
            <!--/row-->
        </div>
        <!--/container-->
    </div>
    <!--/SLIDER-->

    <!--CONTENT-->
    <div class="container">
        <div class="strip">
            <div class="row">
                <div class="span12">
                    <a class="btn btn-red btn-large" href="#"><i class="icon-heart icon-white"></i>Download
                        Sample!</a> <a class="btn btn-inverse btn-large anchorLink" href="#portfolio">Browse
                            Portfolio <i class="icon-share-alt icon-white"></i></a><span class="call-to-action">
                                Download a free sample of our great catalogue and portfolio now!</span>
                    <p>
                        *Don't worry, we have 7 years in the market, we know our stuff.</p>
                </div>
            </div>
        </div>
        <section id="features">
      <div class="row">
        <div class="span12">
          <h2><em><i class="icon-bookmark"></i> Main Features</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>
      <div class="row">   
        <div class="span4 feature">
          <h3>HTML5</h3>
          <img src="../App_Themes/Default/assets/feature-html5.png" width="50" height="50" class="thumb" alt="thumb">
          <p><strong>HTML5</strong> Like you, we love building awesome products on the web. We love it so much, we decided to help people just like us do it easier, better, and faster. Bootstrap is built for you.</p>
        </div>
        <div class="span4 feature">
          <h3>Simple Layout</h3>
          <img src="../App_Themes/Default/assets/feature-layout.png" width="50" height="50" class="thumb" alt="thumb">
          <p>Bootstrap is designed to help people of all skill level—designer or developer, huge nerd or early beginner. Use it as a complete kit or use to start something more complex.</p>
        </div>      
        <div class="span4 feature">
          <h3>Web Fonts</h3>
          <img src="../App_Themes/Default/assets/feature-webfonts.png" class="thumb" alt="thumb">
          <p>Originally built with only modern browsers in mind, Bootstrap has evolved to include support for all major browsers (even IE7!) and, with Bootstrap 2, tablets and smartphones, too.</p>
        </div>
      </div><!--/row-->
      <div class="row">
        <div class="span4 feature">
          <h3>Modern Design</h3>
          <img src="../App_Themes/Default/assets/feature-design.png" class="thumb" alt="thumb">
          <p>The best part about forms in Bootstrap is that all your inputs and controls look great no matter how you build them in your markup.</p>
        </div>
        <div class="span4 feature">
          <h3>Easy to Customize</h3>
          <img src="../App_Themes/Default/assets/feature-customize.png" class="thumb" alt="thumb">
          <p>Different types of form layouts require some changes to markup, but the controls themselves remain and behave the same.</p>
        </div>
        <div class="span4 feature">
          <h3>Great Support</h3>
          <img src="../App_Themes/Default/assets/feature-support.png" class="thumb" alt="thumb">
          <p>States like error, warning, and success are included for each type of form control. Also included are styles for disabled controls. States like error, warning, and success are included.</p>
        </div>
      </div><!--/row-->
    </section>
        <section id="services">
      <div class="row">
        <div class="span12">
        <h2><em><i class="icon-bookmark"></i> Products & Services</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>
      <div class="row">
        <div class="span4">
          <img class="framed" src="../App_Themes/Default/assets/product-1.png" alt=""/>
          <br/>
        </div>
        <div class="span5">
          <h4>Product Overview</h4>
          <p>HD movies and TV shows from iTunes. The entire Netflix streaming catalog. The latest hit shows from Hulu Plus. Live baseball, basketball, and hockey games. Apple TV makes you the master of <a href="#" rel="tooltip" title="fancy tooltip">your own media empire</a>.</p>
          <p>Get to know the latest features available now. Don't forget to checke out our website on a regular basis:</p>
          <ul>
            <li><a href="#" rel="tooltip" data-placement="right" title="fancy tooltip">Mobile ready</a></li>
            <li><a href="#" rel="tooltip" data-placement="right" title="fancy tooltip">Customizable</a></li>
            <li><a href="#" rel="tooltip" data-placement="right" title="fancy tooltip">Great customer support</a></li>
            <li><a href="#" rel="tooltip" data-placement="right" title="fancy tooltip">dropcapproof design</a></li>
          </ul>
        </div>
        <div class="span3">
          <div class="well">
            <strong>Item Details</strong>
            <hr>
            <p><i class="icon-tag"></i> That’s perfect for spontaneous movie nights (or afternoons or mornings). Search by top movies, title, or genre. Can’t decide? Read reviews, watch trailers, and check out Rotten Tomatoes ratings.</p>
          </div>
        </div>
      </div>
      <br/>
      <div class="row">
        <div class="span4">
          <img class="framed" src="../App_Themes/Default/assets/product-2.png" alt=""/>
          <br/>
        </div>
        <div class="span5">
          <h4>Second Product Overview</h4>
          <p>Make any time prime time. Buy your favorite TV shows and watch them — without commercials — whenever you like. <a href="#"  rel="tooltip" title="fancy tooltip">Watch a show the day after it airs</a>, or camp out on your couch and catch up on past seasons with a marathon of back-to-back-to-back episodes. Apple TV keeps track of your favorite shows, so the next time you turn on your TV, you can quickly see which season you’re watching and which episodes are new. Just choose shows with a few clicks of the Apple Remote.</p>
          <p>Like you, we love building awesome products on the web. We love it so much, we decided to help people just like us do it easier, better, and faster. Bootstrap is built for you.</p>
        </div>
        <div class="span3">
          <div class="well">
            <strong>Item Details</strong>
            <hr>
            <p><i class="icon-tag"></i> That’s perfect for spontaneous movie nights (or afternoons or mornings). <a href="#" rel="tooltip" title="fancy tooltip">Search by top movie</a> title, or genre. Can’t decide? Read reviews, watch trailers, and check out Rotten Tomatoes ratings.</p>
          </div>
        </div>
      </div>
      <br/>
      <div class="row">
        <div class="span4">
          <img class="framed" src="../App_Themes/Default/assets/product-3.png" alt=""/>
          <br/>
        </div>
        <div class="span5">
          <h4>Third Product Overview</h4>
          <p>Make any time prime time. Buy your favorite TV shows and watch them — without commercials — whenever you like. Watch a show the day after it airs, or camp out on your couch and catch.</p>
          <hr>
          <blockquote>
            <p>Best service I've ever experienced. Thank you very much for your time.</p>
            <small>Lucida Console</small>
          </blockquote>
          <hr>
        </div>
        <div class="span3">
          <div class="well">
            <strong>Item Details</strong>
            <hr>
            <p><i class="icon-tag"></i> That’s perfect for spontaneous movie nights (or afternoons or mornings). Search by top movies, title, or genre. Can’t decide? Read reviews, watch trailers, and check out Rotten Tomatoes ratings.</p>
          </div>
        </div>
      </div>
      <br/>
      <div class="row">
        <div class="span4">
          <img class="framed" src="../App_Themes/Default/assets/product-4.png" alt=""/>
          <br/>
        </div>
        <div class="span5">
          <h4>Fourth Product Overview</h4>
          <p>Make any time prime time. Buy your favorite TV shows and watch them — without commercials — whenever you like. Watch a show the day after it airs, or camp out on your couch and catch.</p>
          <p>Like you, we love building awesome products on the web. We love it so much, we decided to help people just like us do it easier, better, and faster. <a href="#" rel="tooltip" title="fancy tooltip">Bootstrap</a> is built for you.</p>
        </div>
        <div class="span3">
          <div class="well">
            <strong>Item Details</strong>
            <hr>
            <p><i class="icon-tag"></i> That’s perfect for spontaneous movie nights (or afternoons or mornings). Search by top movies, title, or genre. Can’t decide? Read reviews, watch trailers, and check out Rotten Tomatoes ratings.</p>
          </div>
        </div>
      </div>
    </section>
        <section id="portfolio">
      <div class="row">
        <div class="span12">
          <h2><em><i class="icon-bookmark"></i> Portfolio with LightBox</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>
      <div class="row">
        <div class="span12">
          <ul class="thumbnails">
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #1"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li> 
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #2"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #3"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #4"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #5"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #6"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #7"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
            <li class="span3">
              <div class="thumbnail">
                <a class="js-fancybox" rel="album" href="../App_Themes/Default/assets/portfolio-large-1.png" title="Portfolio Item #8"><img src="../App_Themes/Default/assets/portfolio-thumbnail-1.png" alt=""></a>
                <div class="caption">
                  <h4>Image Title</h4>
                  <hr>
                  <p>Short description for this Portfolio item.</p>
                </div>
              </div>
            </li>
          </ul>
        </div><!--span12-->
      </div><!--/row-->
    </section>
        <section id="about">
      <div class="row">
        <div class="span12">
          <h2><em><i class="icon-bookmark"></i> About & Legal</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>
      <div class="row">
        <div class="span4">
          <div class="well">
            <h3>Terms and Conditions</h3>
            <hr>
            <p><span class="dropcap">1</span> Like you, we love building awesome products on the web. We love it so much, we decided to help people just like us do it easier, better, and faster. Bootstrap is built for you.</p>
            <p>Bootstrap is designed to help people of all skill level—designer or developer, huge nerd or early beginner. Use it as a complete kit or use to start something more complex.</p>
            <a class="btn btn-red" data-toggle="modal" href="#myModal" >Launch Modal</a>
            <div class="modal hide fade" id="myModal">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">×</button>
                <h3>Frequently Asked Questions</h3>
              </div>
              <div class="modal-body">
                <span class="dropcap">1</span> <h4>Can I use your freebies in my latest client project?</h4>
                <p>Yes. No attribution required. When sharing any work that uses my resources on sites like Dribbble or Forrst it would be nice to be credited. You want to make me feel all warm and fuzzy inside don’t you?</p>
                <hr>
                <h4><span class="dropcap">2</span> Can I use your resources in a theme/template?</h4>
                <p>Yes. No attribution required but appreciated. I love people coding up the odd freebie, but an entire blog dedicated to just that is probably a step too far Jack. C’mon Mookie, do the right thing.</p>
                <hr>
                <h4><span class="dropcap">3</span> Can I offer your freebies for download on my blog/site?</h4>
                <p>Not directly no. If you want to share the wealth then linking to each resource on Premium Pixels is encouraged and sincerely appreciated. Linking directly to the zip file, or worse, repackaging your own zip file, gets my goat :(</p>
              </div>
              <div class="modal-footer">
                <a href="#" class="btn btn-red" data-dismiss="modal">Ok, I got it.</a>
              </div>
            </div>
          </div>
        </div>
        <div class="span4">
          <div class="well">
            <h3>Light Weight Defaults</h3>
            <hr>
            <span class="dropcap">2</span> <p>Bootstrap is designed to help people of all skill level—designer or developer, huge nerd or early beginner. Use it as a complete kit or use to start something more complex.</p>
            <p>Like you, we love building awesome products on the web. We love it so much, we decided to help people just like us do it easier, better, and faster. Bootstrap is built for you.</p>
            <a class="btn btn-red" data-toggle="modal" href="#myModal" >Launch Modal</a>
          </div>
        </div>
        <div class="span4">
          <div class="well">
            <h3>Simple & Flexible Markup</h3>
            <hr>
            <p><span class="dropcap">3</span> Like you, we love building awesome products on the web. We love it so much, we decided to help people just like us do it easier, better, and faster. Bootstrap is built for you.</p>
            <p>Bootstrap is designed to help people of all skill level—designer or developer, huge nerd or early beginner. Use it as a complete kit or use to start something more complex.</p>
            <a class="btn btn-red" data-toggle="modal" href="#myModal" >Launch Modal</a>
          </div>
        </div>
      </div><!--/row-->
    </section>
        <section id="contact">
      <div class="row">
        <div class="span12">
          <h2><em><i class="icon-bookmark"></i> Contact Us</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>
      <div class="row">
        <div class="span4">
          <h3>Company Address</h3>
          <br>
          <div class="well">
            <strong>Company:</strong>
            <hr>
            <p>Greg L. Denney<br/>
              4209 Scenicview Drive<br/>
              Redmond, WA 98052<br/>
              Tel.: +1.123.456.789
            </p>
            <p>Don't hesitate to contact us about anything you want. We are open to questios, comments and suggestions.</p>
          </div>
        </div>
        <div class="span4">
        <h3>Time to keep in touch.</h3>
        <br/>
          <form>
            <fieldset>
              <div class="control-group">
                <label class="control-label" for="name">Full Name:</label>
                <input class="input-xlarge" type="text" id="name">
              </div>
              <div class="control-group">
                <label class="control-label" for="email">Valid Email:</label>
                <input type="text" class="input-xlarge" id="email">
              </div>
              <div class="control-group">
                <label class="control-label" for="message">Message:</label>
                <textarea class="input-xlarge" id="message" rows="3"></textarea>
              </div>
              <button type="submit" class="btn btn-red">Submit Now!</button>
            </fieldset>
          </form>
        </div><!--/span-->
        <div class="span4">
          <h3>How about a map?</h3>
          <br/>
          <img class="framed" src="../App_Themes/Default/assets/map.png" alt=""/>
        </div>
      </div><!--/row-->
    </section>
    </div>
    <!--/CONTENT-->
</asp:Content>
