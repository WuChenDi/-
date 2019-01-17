
<div class="mainbox">
  <div class="mainbox1">
    <div class="mainbox11">
        <div class="biaoti"><strong>教育教学</strong><a href="fenleimidium.php?$id=教育教学"><img src="img/icon-more.gif" width="34" height="11" /></a></div>
      <div class="neirong">
      <ul>
            <?php 
		include 'conn.php';  
    $sql="select 刊名,添加日期 from qikan where 所属类型='教育教学' order by 添加日期 desc limit 0,6 ";
	$sql1=$conn->query($sql);
	while ($row = mysqli_fetch_array($sql1)){
	?>
      <li>
     <a href="qikandetail.php?$id=<?php echo $row['刊名'];?>">

		  <?php echo $row['刊名'];?></a><span><?php echo $row['添加日期'];?></span></li>
        <?php
						}
					 ?>
      </ul>
      </div>
   </div>
   
     <div class="mainbox11">
     <div class="biaoti"><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div>
     </div>
      <div class="mainbox11">
      <div class="biaoti"><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div></div>
  </div>
  <div class="mainbox1">
  <div class="mainbox11">
      <div class="biaoti"><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div>
   </div>
     <div class="mainbox11">
     <div class="biaoti"><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div>
     </div>
      <div class="mainbox11">
      <div class="biaoti"></div><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div>
  </div>
  <div class="mainbox1">
   <div class="mainbox11">
      <div class="biaoti"><strong>教育教学</strong><img src="imgicon-more.gif" width="34" height="11" /></div>
   </div>
     <div class="mainbox11">
     <div class="biaoti"><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div>
     </div>
      <div class="mainbox11">
      <div class="biaoti"><strong>教育教学</strong><img src="img/icon-more.gif" width="34" height="11" /></div></div>
  </div>
</div>
