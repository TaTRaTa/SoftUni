<%@ page import="java.util.*" %>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Tseko</title>
</head>
<body>
	<table border=1>
		<tr>
		 	<th>Topic</th>
		 	<th>Date</th>
	 	</tr>
		<tr>
			<td>Tseko</td>
			<td><%= new Date().toGMTString() %>
		</tr>
	</table>

</body>
</html>