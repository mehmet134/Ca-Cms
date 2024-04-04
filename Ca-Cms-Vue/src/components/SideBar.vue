<template>
    <div class="sidebar" id="sidebar">
            <div class="sidebar-inner slimscroll">
                <div id="sidebar-menu" class="sidebar-menu">
                    <ul>
                        <li class="menu-title">Main</li>
                        <li class="active">
                            <a href=""><i class="fa fa-dashboard"></i> <span>Dashboard</span></a>
                        </li>
						<li>
                            <a href=""><i class="fa fa-user-md"></i> <span>Doctors</span></a>
                        </li>
                        <li>
                            <RouterLink class="nav-link" to="/patients"><i class="fa fa-wheelchair"></i> <span>Patients</span></RouterLink>
                        </li>
                        <li>
                            <a href=""><i class="fa fa-calendar"></i> <span>Appointments</span></a>
                        </li>
                        <li>
                            <a href=""><i class="fa fa-calendar-check-o"></i> <span>Doctor Schedule</span></a>
                        </li>
                        <li>
                            <a href=""><i class="fa fa-hospital-o"></i> <span>Departments</span></a>
                        </li>
						<li class="submenu">
							<a href="#"><i class="fa fa-user"></i> <span> Employees </span> <span class="menu-arrow"></span></a>
							<ul style="display: none;">
								<li><a href="">Employees List</a></li>
								<li><a href="">Leaves</a></li>
								<li><a href="">Holidays</a></li>
								<li><a href="">Attendance</a></li>
							</ul>
						</li>
						<li class="submenu">
							<a href="#"><i class="fa fa-money"></i> <span> Accounts </span> <span class="menu-arrow"></span></a>
							<ul style="display: none;">
								<li><a href="">Invoices</a></li>
								<li><a href="">Payments</a></li>
								<li><a href="">Expenses</a></li>
								<li><a href="">Taxes</a></li>
								<li><a href="">Provident Fund</a></li>
							</ul>
						</li>
						<li class="submenu">
							<a href="#"><i class="fa fa-book"></i> <span> Payroll </span> <span class="menu-arrow"></span></a>
							<ul style="display: none;">
								<li><a href=""> Employee Salary </a></li>
								<li><a href=""> Payslip </a></li>
							</ul>
						</li>
                        <li>
                            <a href="chat.html"><i class="fa fa-comments"></i> <span>Chat</span> <span class="badge badge-pill bg-primary float-right">5</span></a>
                        </li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-video-camera camera"></i> <span> Calls</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href="">Voice Call</a></li>
                                <li><a href="">Video Call</a></li>
                                <li><a href="">Incoming Call</a></li>
                            </ul>
                        </li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-envelope"></i> <span> Email</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href="">Compose Mail</a></li>
                                <li><a href="">Inbox</a></li>
                                <li><a href="">Mail View</a></li>
                            </ul>
                        </li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-commenting-o"></i> <span> Blog</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href="">Blog</a></li>
                                <li><a href="l">Blog View</a></li>
                                <li><a href="">Add Blog</a></li>
                                <li><a href="">Edit Blog</a></li>
                            </ul>
                        </li>
						<li>
							<a href=""><i class="fa fa-cube"></i> <span>Assets</span></a>
						</li>
						<li>
							<a href=""><i class="fa fa-bell-o"></i> <span>Activities</span></a>
						</li>
						<li class="submenu">
							<a href="#"><i class="fa fa-flag-o"></i> <span> Reports </span> <span class="menu-arrow"></span></a>
							<ul style="display: none;">
								<li><a href=""> Expense Report </a></li>
								<li><a href=""> Invoice Report </a></li>
							</ul>
						</li>
                        <li>
                            <a href=""><i class="fa fa-cog"></i> <span>Settings</span></a>
                        </li>
                        <li class="menu-title">UI Elements</li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-laptop"></i> <span> Components</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href="">UI Kit</a></li>
                                <li><a href="">Typography</a></li>
                                <li><a href="">Tabs</a></li>
                            </ul>
                        </li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-edit"></i> <span> Forms</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href="">Basic Inputs</a></li>
                                <li><a href="">Input Groups</a></li>
                                <li><a href="">Horizontal Form</a></li>
                                <li><a href="">Vertical Form</a></li>
                            </ul>
                        </li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-table"></i> <span> Tables</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href="">Basic Tables</a></li>
                                <li><a href="">Data Table</a></li>
                            </ul>
                        </li>
                        <li>
                            <a href=""><i class="fa fa-calendar"></i> <span>Calendar</span></a>
                        </li>
                        <li class="menu-title">Extras</li>
                        <li class="submenu">
                            <a href="#"><i class="fa fa-columns"></i> <span>Pages</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li><a href=""> Login </a></li>
                                <li><a href=""> Register </a></li>
                                <li><a href=""> Forgot Password </a></li>
                                <li><a href=""> Change Password </a></li>
                                <li><a href=""> Lock Screen </a></li>
                                <li><a href=""> Profile </a></li>
                                <li><a href=""> Gallery </a></li>
                                <li><a href="">404 Error </a></li>
                                <li><a href="">500 Error </a></li>
                                <li><a href=""> Blank Page </a></li>
                            </ul>
                        </li>
                        <li class="submenu">
                            <a href="javascript:void(0);"><i class="fa fa-share-alt"></i> <span>Multi Level</span> <span class="menu-arrow"></span></a>
                            <ul style="display: none;">
                                <li class="submenu">
                                    <a href="javascript:void(0);"><span>Level 1</span> <span class="menu-arrow"></span></a>
                                    <ul style="display: none;">
                                        <li><a href="javascript:void(0);"><span>Level 2</span></a></li>
                                        <li class="submenu">
                                            <a href="javascript:void(0);"> <span> Level 2</span> <span class="menu-arrow"></span></a>
                                            <ul style="display: none;">
                                                <li><a href="javascript:void(0);">Level 3</a></li>
                                                <li><a href="javascript:void(0);">Level 3</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="javascript:void(0);"><span>Level 2</span></a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a href="javascript:void(0);"><span>Level 1</span></a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
    </div>    
</template>