<%@ tag language="java" pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<c:set var="date" value="<%= (new java.util.Date()).toGMTString() %>"/>
<%@ attribute name="name" %>

<table border=1>
	<tr>
	 	<th>Topic</th>
	 	<th>Date</th>
 	</tr>
 			<tr>
		<td>${name}</td>
		<td>${date}</td>
	</tr>
</table>