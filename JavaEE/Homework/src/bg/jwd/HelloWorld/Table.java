package bg.jwd.HelloWorld;

import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Table
 */
@WebServlet("/Table")
public class Table extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Table() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	
	@SuppressWarnings("deprecation")
	@Override
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.setContentType("text/html");
		
		SimpleDateFormat dt = new SimpleDateFormat("DD-MM-YYYY HH:mm:ss");
		String date = "";
		Calendar c = Calendar.getInstance();
		date = dt.format(c.getTime());
		
		response.getWriter().append("Served at: ").append(request.getContextPath());
		response.getWriter().printf(
				"<table border=1>"
				+ "<thead>"
					+ "<tr>"
						+ "<th>Topic</th>"
						+ "<th>Date</th>"
					+ "</tr>"
				+ "</thead>"
				+ "<tbody>"
					+ "<tr>"
						+ "<td>%s</td>"
						+ "<td>%s</td>"
					+ "</tr>"
				+ "</tbody>"
				+ "</table>","Tseko", date);
	}

}
