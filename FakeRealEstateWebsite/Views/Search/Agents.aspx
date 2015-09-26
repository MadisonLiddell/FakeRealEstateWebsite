<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<FakeRealEstateWebsite.Models.agent>>" %>

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
						<ul class="buttons">
						    <li><a href="#" class="button small">Search</a></li>
					    </ul>
					</header>

                   


					<!-- One -->
						<section class="wrapper style4 container">

                              <table>
                                <tr>
                                    <th>
                                        <%: Html.DisplayNameFor(model => model.agent_fname) %>
                                    </th>
                                    <th>
                                        <%: Html.DisplayNameFor(model => model.agent_lname) %>
                                    </th>
                                    <th>
                                        <%: Html.DisplayNameFor(model => model.agent_phone) %>
                                    </th>
                                    <th>
                                        <%: Html.DisplayNameFor(model => model.agent_city) %>
                                    </th>
                                    <th>
                                        <%: Html.DisplayNameFor(model => model.agent_state) %>
                                    </th>
                                    <th>
                                        <%: Html.DisplayNameFor(model => model.fk_off_code) %>
                                    </th>
                                    <th></th>
                                </tr>

                            <% foreach (var item in Model) { %>
                                <tr>
                                    <td>
                                        <%: Html.DisplayFor(modelItem => item.agent_fname) %>
                                    </td>
                                    <td>
                                        <%: Html.DisplayFor(modelItem => item.agent_lname) %>
                                    </td>
                                    <td>
                                        <%: Html.DisplayFor(modelItem => item.agent_phone) %>
                                    </td>
                                    <td>
                                        <%: Html.DisplayFor(modelItem => item.agent_city) %>
                                    </td>
                                    <td>
                                        <%: Html.DisplayFor(modelItem => item.agent_state) %>
                                    </td>
                                    <td>
                                        <%: Html.DisplayFor(modelItem => item.fk_off_code) %>
                                    </td>
                                </tr>
                            <% } %>

                            </table>

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
