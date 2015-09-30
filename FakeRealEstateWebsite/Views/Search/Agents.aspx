<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<FakeRealEstateWebsite.Models.agent>>" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Agents | RealFake Estates
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
			<%-- main --%>      
				<article id="main">
                    
					<header class="special container">
						<span class="icon fa-mobile"></span>
						<h2>Find an<strong> Agent</strong></h2>
                        <br />
                        <% using (Html.BeginForm("Agents", "Search", FormMethod.Get)) %>
                        <% { %> 
                           
                            <%= @Html.TextBox("searchText", null, new { placeholder = "Name, city, or state" })%>
                            <input type="submit" class="special" value="Search" />
                        <% } %>
					</header>

					<!-- One -->
						<section class="wrapper style4 container">
                            <div class="special container"><h2>Here's the <strong>Agents</strong> we found</h2></div><br />
                            <div class="row">
                            <% foreach (var item in Model) { %>
                                  <div class="4u 12u(narrower)">

									<section>
										<span class="icon featured fa-user"></span>
										<header>
											<h3 class ="special"> <%: Html.DisplayFor(modelItem => item.agent_fname) %> <%: Html.DisplayFor(modelItem => item.agent_lname) %></h3>
										</header>
										<p>Operating out of <strong><%: Html.DisplayFor(modelItem => item.agent_city) %>, <%: Html.DisplayFor(modelItem => item.agent_state) %> </strong><br />
                                            Phone: <%: Html.DisplayFor(modelItem => item.agent_phone) %> <br />
										</p>
									</section>

								</div>
                            <% } %>

                        </div>
                            <%-- added from two --%>
                                <%--<section class="wrapper style1 container special">--%>
							    <%--<div class="row">
								    <div class="4u 12u(narrower)">

									    <section>
										    <header>
											    <h3>Agent 1?</h3>
										    </header>
										    <p>Sed tristique purus vitae volutpat ultrices. Aliquam eu elit eget arcu commodo suscipit dolor nec nibh. Proin a ullamcorper elit, et sagittis turpis. Integer ut fermentum.</p>
										    <footer>
											    <ul class="buttons">
												    <li><a href="#" class="button small">Learn More</a></li>
											    </ul>
										    </footer>
									    </section>

								    </div>
								    <div class="4u 12u(narrower)">

									    <section>
										    <header>
											    <h3>Another agent</h3>
										    </header>
										    <p>Sed tristique purus vitae volutpat ultrices. Aliquam eu elit eget arcu commodo suscipit dolor nec nibh. Proin a ullamcorper elit, et sagittis turpis. Integer ut fermentum.</p>
										    <footer>
											    <ul class="buttons">
												    <li><a href="#" class="button small">Learn More</a></li>
											    </ul>
										    </footer>
									    </section>

								    </div>
								    <div class="4u 12u(narrower)">

									    <section>
										    <header>
											    <h3>Probably Something</h3>
										    </header>
										    <p>Sed tristique purus vitae volutpat ultrices. Aliquam eu elit eget arcu commodo suscipit dolor nec nibh. Proin a ullamcorper elit, et sagittis turpis. Integer ut fermentum.</p>
										    <footer>
											    <ul class="buttons">
												    <li><a href="#" class="button small">Learn More</a></li>
											    </ul>
										    </footer>
									    </section>

								    </div>
							    </div>--%>
						    <%--</section>--%>

						</section>

					<!-- Two -->
						

				</article>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
