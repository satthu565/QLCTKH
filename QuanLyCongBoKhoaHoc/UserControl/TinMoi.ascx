﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TinMoi.ascx.cs" Inherits="QuanLyCongBoKhoaHoc.UserControl.TinMoi" %>


<div class="panel panel-primary" style="border-color:#382A7F">
    <div class="panel-heading" style="background-color:#382A7F;border-color:#382A7F">
        <h3 class="panel-title">Tin mới</h3>
    </div>
     <div class="panel-body" style="height:260px" >
         <div id="newsticker-demo">
             <div style="visibility: visible; overflow: hidden; position: relative; z-index: 2; left: 0px; height: 235px !important;"
                 class="newsticker-jcarousellite" >
                 <ul style="margin: 0pt; padding: 0pt; position: relative; list-style-type: none; z-index: 1;  top: -245.835px;">
                     <%  
                         for (int i = 0; i < TbCongBo.Rows.Count; i++)
                         {  
                     %>
                     <li style="overflow: hidden; width: 100%; margin-bottom:25px; height:initial !important">
                         <div class="media">  
                             <div class="media-body">
                                 <a rel="nofollow" href='#'>
                                     <h5 class="media-heading" style="color:blue"><% Response.Write(TbCongBo.Rows[i]["TenCongTrinh"].ToString()); %>
                                     </h5>
                                 </a>
                             </div>
                         </div>
                     </li>
                     <%}%>
                 </ul>
             </div>
         </div>
    </div>
</div>



